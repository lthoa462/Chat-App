using ChapAppClient.DTO;
using ChatAppServer.DTO;
using ChatAppServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapAppClient
{
    public partial class HomeForm : Form
    {
        private delegate void AddItemForListView(string name , Guid userId,string username);

        private delegate void ClearListViewItems();

        private delegate void SetTextDelegate(List<string> text);
        private delegate void SetTextDelegateLvMess(AllMess text);
        private LoginForm loginFrom;
        public string grName;

        public HomeForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginFrom = loginForm;
            dgvUsers.AllowUserToAddRows = false;
        }

        public void addItemForFriendListView(string name , Guid userId, string username)
        {
            if (dgvUsers.InvokeRequired)
            {
                var dlg = new AddItemForListView(addItemForFriendListView);
                this.Invoke(dlg, new object[] { name , userId , username });
            }
            else
            {
                dgvUsers.Rows.Add(name, userId , username);
            }
        }
        public void addItemForlvChat(AllMess mess)
        {
            if (lvChat.InvokeRequired)
            {
                var dlg = new SetTextDelegateLvMess(addItemForlvChat);
                lvChat.Invoke(dlg, new object[] { mess });
            }
            else
            {
                lvChat.Clear();
                foreach(var item in mess.chatMessages)
                {
                    var dlv = new ListViewItem("");
                    if (item.CreatedBy == this.loginFrom.user.UserId)
                    {
                        dlv.Text = item.Content;
                    }
                    else dlv.Text = item.Content;
                    lvChat.Items.Add(dlv);
                }
                
            }
        }

        public void clearItems()
        {
            if (dgvUsers.InvokeRequired)
            {
                var dlg = new ClearListViewItems(clearItems);
                this.Invoke(dlg, new object[] { });
            }
            else
            {
                dgvUsers.Rows.Clear();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchFriend.Text == "")
            {
                return;
            }
            clearItems();
            loginFrom.searchUserByName(tbSearchFriend.Text);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.loginFrom.Start();
        }

        public void SetTextToLvGroup(List<string> text)
        {
            if (lvGroup.InvokeRequired)
            {
                var dlg = new SetTextDelegate(SetTextToLvGroup);
                lvGroup.Invoke(dlg, new object[] { text });
            }
            else
            {
                lvGroup.Clear();
                lvGroup.Items.Clear();
                lvGroup.Columns.Add("Group", -2, HorizontalAlignment.Center);
                lvGroup.FullRowSelect = true;
                lvGroup.GridLines = true;
                lvGroup.View = System.Windows.Forms.View.List;
                foreach(var item in text)
                {
                    var lvi = new ListViewItem(item);
                    lvi.Tag = item;
                    lvGroup.Items.Add(lvi);
                }
                lvGroup.Focus();

            }
        }


        private void btApprove_Click(object sender, EventArgs e)
        {
            var user = this.loginFrom.user;
            var request = new Base { action = "getall", model = "group", content = new GetGroupByUser { userID = user.UserId }.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        private void lvGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lvGroup.SelectedItems[0].Tag.ToString();
            grName = item;
            var group = this.loginFrom.listGr.Find(x => x.GroupName == item);
            var request = new Base { action = "getallmess", model = "chat", content = new GetByGroup { GroupID = group.GroupId }.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            var messContent = tbMessage.Text;
            var mess = new ChatMessage { Content = messContent, GroupId = this.loginFrom.listGr.Find(x => x.GroupName == grName).GroupId, CreatedBy = this.loginFrom.user.UserId, CreatedDate = DateTime.Now, MessageId = Guid.NewGuid() };
            var request = new Base { action = "send", model = "chat", content = mess.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            var messContent = tbMessage.Text;
            var mess = new ChatMessage { Content = messContent, GroupId = this.loginFrom.listGr.Find(x => x.GroupName == grName).GroupId, CreatedBy = this.loginFrom.user.UserId, CreatedDate = DateTime.Now, MessageId = Guid.NewGuid() };
            var request = new Base { action = "send", model = "chat", content = mess.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        private void btAddFriend_Click(object sender, EventArgs e)
        {
            Int32 rowsCount = dgvUsers.SelectedRows.Count;
            if(rowsCount <= 0)
            {
                return;
            }
            List<AddFriendDTO> dto = new List<AddFriendDTO>();
            for(int i = 0;i < rowsCount; i++)
            {
                dto.Add(new AddFriendDTO
                {
                    name = (string)dgvUsers.SelectedRows[i].Cells[0].Value,
                    userId = (Guid)dgvUsers.SelectedRows[i].Cells[1].Value,
                    userName = (string)dgvUsers.SelectedRows[i].Cells[2].Value
                });
            }
            this.loginFrom.addFriends(dto);
        }
    }
}
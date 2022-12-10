using ChapAppClient.DTO;
using ChatAppServer.DTO;
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
        private LoginForm loginFrom;

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
                lvGroup.Items.Clear();
                lvGroup.Columns.Add("Group", -2, HorizontalAlignment.Center);
                lvGroup.FullRowSelect = true;
                lvGroup.GridLines = true;
                lvGroup.View = System.Windows.Forms.View.List;
                foreach(var item in text)
                {
                    var lvi = new ListViewItem(item);
                    lvGroup.Items.Add(lvi);
                }
                lvGroup.Focus();
                lvGroup.Items[0].Selected = true;

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
            var item = lvGroup.SelectedItems[0];
            var group = this.loginFrom.listGr.Find(x => x.GroupName == item.Text);

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

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
            var dtoJson = JsonSerializer.Serialize(dto);
            this.loginFrom.addFriends(dtoJson);
        }
    }
}
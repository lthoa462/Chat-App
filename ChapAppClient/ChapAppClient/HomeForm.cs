using ChapAppClient.DTO;
using ChatAppServer.DTO;
using ChatAppServer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapAppClient
{
    public partial class HomeForm : Form
    {
        private delegate void AddItemForListView(string name , Guid userId,string username);

        private delegate void ClearListViewItems();

        private delegate void SetTextDelegate(List<ChatGroup> text);
        private delegate void SetTextDelegateLvMess(AllMess text);
        private LoginForm loginFrom;
        public string grName;
        public List<Guid> grHaveNewMess = new List<Guid>();
        public Guid currentGr;

        public HomeForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginFrom = loginForm;
            dgvUsers.AllowUserToAddRows = false;
            dgvGroups.AllowUserToAddRows = false;
            dgvMessages.AllowUserToAddRows = false;
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
            if (dgvMessages.InvokeRequired)
            {
                var dlg = new SetTextDelegateLvMess(addItemForlvChat);
                dgvMessages.Invoke(dlg, new object[] { mess });
            }
            else
            {
                var list = mess.chatMessages.OrderBy(x => x.CreatedDate);
                dgvMessages.Rows.Clear();
                foreach(var item in list)
                {
                    dgvMessages.Rows.Add(item.sendBy ?? "",item.Content,item.CreatedDate.ToString());
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
            var user = this.loginFrom.user;
            var request = new Base { action = "getall", model = "group", content = new GetGroupByUser { userID = user.UserId }.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        public void SetTextToLvGroup(List<ChatGroup> chatGroups)
        {
            if (dgvGroups.InvokeRequired)
            {
                var dlg = new SetTextDelegate(SetTextToLvGroup);
                dgvGroups.Invoke(dlg, new object[] { chatGroups });
            }
            else
            {
                dgvGroups.Rows.Clear();
                foreach(var item in chatGroups)
                {
                    dgvGroups.Rows.Add(item.GroupId,item.GroupName);
                    if (grHaveNewMess!=null && grHaveNewMess.Any(x=>x == item.GroupId)) dgvGroups.CurrentRow.DefaultCellStyle.Font = new Font(dgvGroups.Font, FontStyle.Bold);
                }
            }
        }


        private void btApprove_Click(object sender, EventArgs e)
        {
            var user = this.loginFrom.user;
            var request = new Base { action = "getall", model = "group", content = new GetGroupByUser { userID = user.UserId }.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            var messContent = tbMessage.Text;
            var mess = new ChatMessage { Content = messContent, GroupId = this.loginFrom.listGr.Find(x => x.GroupName == grName).GroupId,sendBy = this.loginFrom.user.UserName, CreatedBy = this.loginFrom.user.UserId, CreatedDate = DateTime.Now, MessageId = Guid.NewGuid() };
            var request = new Base { action = "send", model = "chat", content = mess.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
            tbMessage.Text = "";
            dgvMessages.Rows.Add(this.loginFrom.user.UserName,messContent , DateTime.Now);
        }

        private void btAddFriend_Click(object sender, EventArgs e)
        {
            Int32 rowsCount = dgvUsers.SelectedRows.Count;
            if (rowsCount <= 0)
            {
                return;
            }
            List<AddFriendDTO> dto = new List<AddFriendDTO>();
            for (int i = 0; i < rowsCount; i++)
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

        private void dgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var groupId = (Guid)dgvGroups.Rows[e.RowIndex].Cells[0].Value;
            currentGr = groupId;
            if (grHaveNewMess != null && grHaveNewMess.Any(x => x == groupId)) grHaveNewMess.Remove(groupId);
            this.grName = dgvGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
            var request = new Base { action = "getallmess", model = "chat", content = new GetByGroup { GroupID = groupId }.ParseToJson() };
            this.loginFrom.Send(request.ParseToJson());
        }
	}
}
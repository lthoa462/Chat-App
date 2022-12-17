namespace ChapAppClient
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.btApprove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearchFriend = new System.Windows.Forms.RichTextBox();
            this.dgvFriend = new System.Windows.Forms.DataGridView();
            this.pickColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddFriend = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(320, 628);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(836, 46);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.Text = "";
            // 
            // btSendMessage
            // 
            this.btSendMessage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSendMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btSendMessage.Location = new System.Drawing.Point(1163, 628);
            this.btSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(75, 46);
            this.btSendMessage.TabIndex = 3;
            this.btSendMessage.Text = "Send";
            this.btSendMessage.UseVisualStyleBackColor = false;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // btApprove
            // 
            this.btApprove.Location = new System.Drawing.Point(11, 268);
            this.btApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btApprove.Name = "btApprove";
            this.btApprove.Size = new System.Drawing.Size(147, 46);
            this.btApprove.TabIndex = 4;
            this.btApprove.Text = "Làm mới";
            this.btApprove.UseVisualStyleBackColor = true;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Từ chối";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(245, 318);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(69, 32);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearchFriend
            // 
            this.tbSearchFriend.Location = new System.Drawing.Point(12, 318);
            this.tbSearchFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchFriend.Name = "tbSearchFriend";
            this.tbSearchFriend.Size = new System.Drawing.Size(227, 32);
            this.tbSearchFriend.TabIndex = 8;
            this.tbSearchFriend.Text = "";
            // 
            // dgvFriend
            // 
            this.dgvFriend.ColumnHeadersHeight = 29;
            this.dgvFriend.Location = new System.Drawing.Point(0, 0);
            this.dgvFriend.Name = "dgvFriend";
            this.dgvFriend.RowHeadersWidth = 51;
            this.dgvFriend.Size = new System.Drawing.Size(240, 150);
            this.dgvFriend.TabIndex = 0;
            // 
            // pickColumn
            // 
            this.pickColumn.HeaderText = "";
            this.pickColumn.MinimumWidth = 6;
            this.pickColumn.Name = "pickColumn";
            this.pickColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pickColumn.Width = 125;
            // 
            // colUsers
            // 
            this.colUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsers.HeaderText = "Users";
            this.colUsers.MinimumWidth = 6;
            this.colUsers.Name = "colUsers";
            // 
            // btAddFriend
            // 
            this.btAddFriend.Location = new System.Drawing.Point(11, 629);
            this.btAddFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddFriend.Name = "btAddFriend";
            this.btAddFriend.Size = new System.Drawing.Size(301, 46);
            this.btAddFriend.TabIndex = 11;
            this.btAddFriend.Text = "Kết bạn";
            this.btAddFriend.UseVisualStyleBackColor = true;
            this.btAddFriend.Click += new System.EventHandler(this.btAddFriend_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameUser,
            this.userId,
            this.username});
            this.dgvUsers.Location = new System.Drawing.Point(11, 358);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(301, 267);
            this.dgvUsers.TabIndex = 12;
            // 
            // nameUser
            // 
            this.nameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameUser.HeaderText = "Users";
            this.nameUser.MinimumWidth = 6;
            this.nameUser.Name = "nameUser";
            this.nameUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userId
            // 
            this.userId.HeaderText = "UserId";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.Visible = false;
            this.userId.Width = 125;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.message,
            this.datetime});
            this.dgvMessages.Location = new System.Drawing.Point(320, 12);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowHeadersWidth = 51;
            this.dgvMessages.RowTemplate.Height = 24;
            this.dgvMessages.Size = new System.Drawing.Size(917, 611);
            this.dgvMessages.TabIndex = 13;
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.Width = 125;
            // 
            // message
            // 
            this.message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            // 
            // datetime
            // 
            this.datetime.HeaderText = "";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.Width = 125;
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupId,
            this.groupName});
            this.dgvGroups.Location = new System.Drawing.Point(9, 12);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.RowHeadersWidth = 51;
            this.dgvGroups.RowTemplate.Height = 24;
            this.dgvGroups.Size = new System.Drawing.Size(302, 251);
            this.dgvGroups.TabIndex = 14;
            this.dgvGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellClick);
            // 
            // groupId
            // 
            this.groupId.HeaderText = "GroupId";
            this.groupId.MinimumWidth = 6;
            this.groupId.Name = "groupId";
            this.groupId.Visible = false;
            // 
            // groupName
            // 
            this.groupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupName.HeaderText = "Group Name";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 686);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btAddFriend);
            this.Controls.Add(this.tbSearchFriend);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btApprove);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox tbMessage;
        public System.Windows.Forms.Button btSendMessage;
        public System.Windows.Forms.Button btApprove;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btSearch;
        public System.Windows.Forms.RichTextBox tbSearchFriend;
        private System.Windows.Forms.DataGridView dgvFriend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pickColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsers;
        public System.Windows.Forms.Button btAddFriend;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
    }
}
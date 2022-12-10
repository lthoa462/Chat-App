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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.btApprove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearchFriend = new System.Windows.Forms.RichTextBox();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.dgvFriend = new System.Windows.Forms.DataGridView();
            this.pickColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCreateGroup = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.selectUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(240, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(689, 498);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(240, 510);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(628, 38);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.Text = "";
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // btSendMessage
            // 
            this.btSendMessage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSendMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btSendMessage.Location = new System.Drawing.Point(872, 510);
            this.btSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(56, 37);
            this.btSendMessage.TabIndex = 3;
            this.btSendMessage.Text = "Send";
            this.btSendMessage.UseVisualStyleBackColor = false;
            // 
            // btApprove
            // 
            this.btApprove.Location = new System.Drawing.Point(8, 218);
            this.btApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btApprove.Name = "btApprove";
            this.btApprove.Size = new System.Drawing.Size(110, 37);
            this.btApprove.TabIndex = 4;
            this.btApprove.Text = "Làm mới";
            this.btApprove.UseVisualStyleBackColor = true;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Từ chối";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(184, 258);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(52, 26);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearchFriend
            // 
            this.tbSearchFriend.Location = new System.Drawing.Point(9, 258);
            this.tbSearchFriend.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchFriend.Name = "tbSearchFriend";
            this.tbSearchFriend.Size = new System.Drawing.Size(171, 27);
            this.tbSearchFriend.TabIndex = 8;
            this.tbSearchFriend.Text = "";
            // 
            // lvGroup
            // 
            this.lvGroup.HideSelection = false;
            this.lvGroup.Location = new System.Drawing.Point(8, 10);
            this.lvGroup.Margin = new System.Windows.Forms.Padding(2);
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.Size = new System.Drawing.Size(228, 206);
            this.lvGroup.TabIndex = 9;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            // 
            // dgvFriend
            // 
            this.dgvFriend.Location = new System.Drawing.Point(0, 0);
            this.dgvFriend.Name = "dgvFriend";
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
            // btCreateGroup
            // 
            this.btCreateGroup.Location = new System.Drawing.Point(8, 511);
            this.btCreateGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btCreateGroup.Name = "btCreateGroup";
            this.btCreateGroup.Size = new System.Drawing.Size(226, 37);
            this.btCreateGroup.TabIndex = 11;
            this.btCreateGroup.Text = "Tạo Group";
            this.btCreateGroup.UseVisualStyleBackColor = true;
            this.btCreateGroup.Click += new System.EventHandler(this.btCreateGroup_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectUser,
            this.nameUser,
            this.userId});
            this.dgvUsers.Location = new System.Drawing.Point(8, 291);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(226, 215);
            this.dgvUsers.TabIndex = 12;
            // 
            // selectUser
            // 
            this.selectUser.HeaderText = "";
            this.selectUser.Name = "selectUser";
            this.selectUser.Width = 50;
            // 
            // nameUser
            // 
            this.nameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameUser.HeaderText = "Users";
            this.nameUser.Name = "nameUser";
            this.nameUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userId
            // 
            this.userId.HeaderText = "UserId";
            this.userId.Name = "userId";
            this.userId.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btCreateGroup);
            this.Controls.Add(this.lvGroup);
            this.Controls.Add(this.tbSearchFriend);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btApprove);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.RichTextBox tbMessage;
        public System.Windows.Forms.Button btSendMessage;
        public System.Windows.Forms.Button btApprove;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btSearch;
        public System.Windows.Forms.RichTextBox tbSearchFriend;
        public System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.DataGridView dgvFriend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pickColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsers;
        public System.Windows.Forms.Button btCreateGroup;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
    }
}
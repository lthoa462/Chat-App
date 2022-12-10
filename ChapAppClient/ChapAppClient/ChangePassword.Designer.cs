namespace ChapAppClient
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEnterNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassWord = new System.Windows.Forms.Button();
            this.btnCloseFrom = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đổi Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(61, 62);
            this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(188, 20);
            this.tbCurrentPassword.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(61, 109);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(188, 20);
            this.tbNewPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(58, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter New Password";
            // 
            // tbEnterNewPassword
            // 
            this.tbEnterNewPassword.Location = new System.Drawing.Point(61, 155);
            this.tbEnterNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnterNewPassword.Name = "tbEnterNewPassword";
            this.tbEnterNewPassword.Size = new System.Drawing.Size(188, 20);
            this.tbEnterNewPassword.TabIndex = 16;
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChangePassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassWord.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChangePassWord.Location = new System.Drawing.Point(61, 198);
            this.btnChangePassWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(87, 36);
            this.btnChangePassWord.TabIndex = 17;
            this.btnChangePassWord.Text = "Đổi Mật Khẩu";
            this.btnChangePassWord.UseVisualStyleBackColor = false;
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // btnCloseFrom
            // 
            this.btnCloseFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCloseFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrom.Location = new System.Drawing.Point(170, 198);
            this.btnCloseFrom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseFrom.Name = "btnCloseFrom";
            this.btnCloseFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCloseFrom.Size = new System.Drawing.Size(79, 36);
            this.btnCloseFrom.TabIndex = 18;
            this.btnCloseFrom.Text = "Hủy Bỏ";
            this.btnCloseFrom.UseVisualStyleBackColor = false;
            this.btnCloseFrom.Click += new System.EventHandler(this.btnCloseFrom_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelWarning.Location = new System.Drawing.Point(95, 183);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 13);
            this.LabelWarning.TabIndex = 19;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.btnCloseFrom);
            this.Controls.Add(this.btnChangePassWord);
            this.Controls.Add(this.tbEnterNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEnterNewPassword;
        private System.Windows.Forms.Button btnChangePassWord;
        private System.Windows.Forms.Button btnCloseFrom;
        private System.Windows.Forms.Label LabelWarning;
    }
}
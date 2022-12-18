namespace ChapAppClient
{
    partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDangKy = new System.Windows.Forms.Button();
			this.lbWarning = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbRePassword = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btnBackLogin = new System.Windows.Forms.Button();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(37, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(109, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tạo tài khoản";
			// 
			// btnDangKy
			// 
			this.btnDangKy.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangKy.ForeColor = System.Drawing.Color.White;
			this.btnDangKy.Location = new System.Drawing.Point(213, 287);
			this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDangKy.Name = "btnDangKy";
			this.btnDangKy.Size = new System.Drawing.Size(128, 34);
			this.btnDangKy.TabIndex = 3;
			this.btnDangKy.Text = "Đăng ký";
			this.btnDangKy.UseVisualStyleBackColor = false;
			this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
			// 
			// lbWarning
			// 
			this.lbWarning.AutoSize = true;
			this.lbWarning.ForeColor = System.Drawing.Color.Crimson;
			this.lbWarning.Location = new System.Drawing.Point(144, 258);
			this.lbWarning.Name = "lbWarning";
			this.lbWarning.Size = new System.Drawing.Size(0, 16);
			this.lbWarning.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(21, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nhập lại mật khẩu";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(75, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Mật khẩu";
			// 
			// tbUsername
			// 
			this.tbUsername.Location = new System.Drawing.Point(147, 134);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(193, 22);
			this.tbUsername.TabIndex = 8;
			// 
			// tbRePassword
			// 
			this.tbRePassword.Location = new System.Drawing.Point(147, 222);
			this.tbRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbRePassword.Name = "tbRePassword";
			this.tbRePassword.Size = new System.Drawing.Size(193, 22);
			this.tbRePassword.TabIndex = 9;
			this.tbRePassword.UseSystemPasswordChar = true;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(147, 177);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(193, 22);
			this.tbPassword.TabIndex = 10;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// btnBackLogin
			// 
			this.btnBackLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackLogin.ForeColor = System.Drawing.Color.Black;
			this.btnBackLogin.Location = new System.Drawing.Point(67, 287);
			this.btnBackLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBackLogin.Name = "btnBackLogin";
			this.btnBackLogin.Size = new System.Drawing.Size(128, 34);
			this.btnBackLogin.TabIndex = 11;
			this.btnBackLogin.Text = "Quay về";
			this.btnBackLogin.UseVisualStyleBackColor = false;
			this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(147, 94);
			this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(193, 22);
			this.tbName.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(37, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tên đăng nhập";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(407, 370);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnBackLogin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbRePassword);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbWarning);
			this.Controls.Add(this.btnDangKy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnDangKy;
        public System.Windows.Forms.Label lbWarning;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbUsername;
        public System.Windows.Forms.TextBox tbRePassword;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Button btnBackLogin;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label label3;
    }
}
namespace ChapAppClient
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnDangky = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.lbWarning = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.ForeColor = System.Drawing.Color.White;
			this.btnDangNhap.Location = new System.Drawing.Point(143, 314);
			this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(123, 44);
			this.btnDangNhap.TabIndex = 0;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnDangky
			// 
			this.btnDangky.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangky.ForeColor = System.Drawing.Color.White;
			this.btnDangky.Location = new System.Drawing.Point(290, 316);
			this.btnDangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDangky.Name = "btnDangky";
			this.btnDangky.Size = new System.Drawing.Size(123, 44);
			this.btnDangky.TabIndex = 1;
			this.btnDangky.Text = "Đăng ký";
			this.btnDangky.UseVisualStyleBackColor = false;
			this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(214, 202);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(199, 22);
			this.tbPassword.TabIndex = 4;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbUsername
			// 
			this.tbUsername.Location = new System.Drawing.Point(214, 146);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(199, 22);
			this.tbUsername.TabIndex = 5;
			// 
			// lbWarning
			// 
			this.lbWarning.AutoSize = true;
			this.lbWarning.ForeColor = System.Drawing.Color.DarkRed;
			this.lbWarning.Location = new System.Drawing.Point(164, 297);
			this.lbWarning.Name = "lbWarning";
			this.lbWarning.Size = new System.Drawing.Size(0, 16);
			this.lbWarning.TabIndex = 6;
			// 
			// tbServer
			// 
			this.tbServer.Location = new System.Drawing.Point(214, 260);
			this.tbServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(199, 22);
			this.tbServer.TabIndex = 7;
			this.tbServer.Text = "192.168.3.58";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(124, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "Server";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(191, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 116);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(530, 415);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.lbWarning);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDangky);
			this.Controls.Add(this.btnDangNhap);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}


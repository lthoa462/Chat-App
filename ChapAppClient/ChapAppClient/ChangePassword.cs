using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapAppClient
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                 
                 LabelWarning.Text = "Mật khẩu cũ không được để trống";
                 return;
            }
            
           if(string.IsNullOrEmpty(tbNewPassword.Text))
            {
                
                LabelWarning.Text = "Mật khẩu mới không được để trống";
                return;
            }    
           if(string.IsNullOrEmpty(tbEnterNewPassword.Text))
            {
                
                LabelWarning.Text = "Mật khẩu nhập lại không được để trống";
                return;
            }
           if (tbNewPassword.Text != tbEnterNewPassword.Text)
            {
                
                LabelWarning.Text = "Mật khẩu mới không trùng khớp";
                return;
            }
        }

        private void btnCloseFrom_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

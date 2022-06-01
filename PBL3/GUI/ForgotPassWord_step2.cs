using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3
{
    public partial class ForgotPassWord_step2 : Form
    {
        private Account userForgotten = null;
        public ForgotPassWord_step2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
        }
        public ForgotPassWord_step2(Account account)
        {
            userForgotten = account;
            InitializeComponent();
        }

        private void btn_confirmChangePassword_Click(object sender, EventArgs e)
        {
            if(txt_password.Text != "" && txt_password != null)
            {
                if (txt_password.Text == txt_rePassword.Text)
                {
                    Provider.Instance.database.Accounts.Where(a => a.Username == userForgotten.Username).FirstOrDefault().Password = txt_password.Text;
                    Provider.Instance.database.SaveChanges();
                    MessageBox.Show("Password changed!", "NOTICE");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match!", "NOTICE");
                }
            }
            else
            {
                MessageBox.Show("Password can not null!", "NOTICE");
            }

        }
        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "btn_showPassword":
                    txt_password.PasswordChar = '\0';
                    break;
                case "btn_reShowPassword":
                    txt_rePassword.PasswordChar = '\0';
                    break;
                default:
                    break;
            }

        }

        private void btn_showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "btn_showPassword":
                    txt_password.PasswordChar = '*';
                    break;
                case "btn_reShowPassword":
                    txt_rePassword.PasswordChar = '*';
                    break;
                default:
                    break;
            }
        }
    }
}

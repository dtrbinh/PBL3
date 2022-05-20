using PBL3.BLL;
using PBL3.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class ForgotPassWord_step2 : Form
    {
        private Account userForgotten = null;
        public ForgotPassWord_step2()
        {
            InitializeComponent();
        }
        public ForgotPassWord_step2(Account account)
        {
            userForgotten = account;
            InitializeComponent();
        }

        private void btn_confirmChangePassword_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_rePassword.Text)
            {
                foreach (Account i in Provider.Instance.database.Accounts)
                {
                    if (userForgotten.Username == i.Username)
                    {
                        i.Password = txt_password.Text;
                        MessageBox.Show("Password changed!", "NOTICE");
                        this.Close();
                        break;
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Password does not match!", "NOTICE");
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

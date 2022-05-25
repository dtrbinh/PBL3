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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_cmnd.Text != "")
            {
                if (txt_password.Text == txt_rePassword.Text && txt_password.Text != "")
                {
                    string cmnd = txt_cmnd.Text;
                    string username = txt_username.Text;
                    string password = txt_password.Text;
                    bool flag = true;
                    foreach (Account i in Provider.Instance.database.Accounts)
                    {
                        if (i.Username == username)
                        {
                            flag = false;
                            MessageBox.Show("Username or CMND/CCCD already exist.", "NOTICE");
                            break;
                        }
                    }
                    if (flag)
                    {
                        Account newAccount = new Account(cmnd, username, password, false);
                        Provider.Instance.database.Accounts.Add(newAccount);
                        Provider.Instance.database.SaveChanges();
                        MessageBox.Show("Create account successfully.", "NOTICE");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Password does not match!", "NOTICE");
                }
            }
            else
            {
                MessageBox.Show("CMND/CCCD or Username can not blank!", "NOTICE");
            }

        }
    }
}

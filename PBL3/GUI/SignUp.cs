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
using PBL3.BLL;

namespace PBL3
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
        }

        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "btn_showPassword":
                    txtPassword.PasswordChar = '\0';
                    break;
                case "btn_reShowPassword":
                    txtRepassword.PasswordChar = '\0';
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
                    txtPassword.PasswordChar = '*';
                    break;
                case "btn_reShowPassword":
                    txtRepassword.PasswordChar = '*';
                    break;
                default:
                    break;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text != "" && txtUsername.Text != "" && txtCMND.Text != "")
            {
                if (txtPassword.Text == txtRepassword.Text && txtPassword.Text != "")
                {
                    bool flag = true;
                    foreach (Account i in Provider.Instance.database.Accounts)
                    {
                        if (i.Username == txtUsername.Text)
                        {
                            flag = false;
                            MessageBox.Show("Username or CMND/CCCD already existed.", "NOTICE");
                            break;
                        }
                    }
                    if (flag)
                    {
                        Account newAccount = new Account
                        {
                            Fullname = txtFullname.Text,
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            CMND = txtCMND.Text,
                            Permission = false
                        };
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
                MessageBox.Show("CMND/CCCD, Username and Full Name Fields can not be blank!", "NOTICE");
            }
        }
    }
}

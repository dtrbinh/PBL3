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
    }
}

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
            this.BackColor = Color.FromArgb(55, 54, 92);
        }

        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '\0';
        }

        private void btn_showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void btn_reShowPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_rePassword.PasswordChar = '\0';
        }

        private void btn_reShowPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_rePassword.PasswordChar = '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}

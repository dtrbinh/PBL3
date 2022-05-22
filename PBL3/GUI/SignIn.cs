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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword_step1 fg_1 = new ForgotPassword_step1();
            fg_1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
        }

        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '\0';
        }

        private void btn_showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3
{
    public partial class ForgotPassword2 : Form
    {
        public ForgotPassword2()
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
                    txtRePassword.PasswordChar = '\0';
                    break;
                default:
                    break;
            }
        }
        private Account userForgotten = null;
        public ForgotPassword2(Account account)
        {
            userForgotten = account;
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRePassword.Text)
            {
                Provider.Instance.database.Accounts.Where(a => a.Username == userForgotten.Username).FirstOrDefault().Password = txtPassword.Text;
                Provider.Instance.database.SaveChanges();
                MessageBox.Show("Password changed!", "NOTICE");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match!", "NOTICE");
            }
        }
    }
}

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
    public partial class ForgotPassword_step1 : Form
    {
        public ForgotPassword_step1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_checkUsernameValid_Click(object sender, EventArgs e)
        {
            Account userForgotten = null;
            string username = txt_username.Text;
            foreach (Account i in Provider.Instance.database.Accounts)
            {
                if (username == i.Username)
                {
                    userForgotten = i;
                    break;
                }
                else
                { }
            }
            if (userForgotten != null)
            {
                ForgotPassWord_step2 fg_2 = new ForgotPassWord_step2(userForgotten);
                this.Close();
                fg_2.Show(); 
            }
            else
            {
                MessageBox.Show("Does not exist this user.", "NOTICE");
            }
        }
    }
}

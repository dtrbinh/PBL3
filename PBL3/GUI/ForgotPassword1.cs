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
    public partial class ForgotPassword1 : Form
    {
        public ForgotPassword1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Account userForgotten = null;
            string username = txtUsername.Text;
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
                ForgotPassword2 fg_2 = new ForgotPassword2(userForgotten);
                this.Close();
                fg_2.Show();
            }
            else
            {
                MessageBox.Show("This user does not exist!.", "NOTICE");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}

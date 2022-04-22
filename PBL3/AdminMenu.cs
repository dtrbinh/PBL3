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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private Form acctiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (acctiveForm != null)
                acctiveForm.Close();
            acctiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        /*
         đoạn code giúp hide và open cá sub
         */
        private void customizeDesing()
        {
            panelSubData.Visible = false;
            panelsubAccount.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubData.Visible == true)
                panelSubData.Visible = false;
            if (panelsubAccount.Visible == true)
                panelsubAccount.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());
        }

        private void btnDataManaging_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubData);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // code
            openChildForm(new CitizenData());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // code

        }
        private void button8_Click(object sender, EventArgs e)
        {
            // code

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistics());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountSettings_Account());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubAccount);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountSettings_UserMnaging());
        }
    }
}

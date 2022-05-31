using PBL3.GUI;
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
            CustomizeDesign();
        }

        private Form acctiveForm = null;
        private void OpenChildForm(Form ChildForm)
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

        private void CustomizeDesign()
        {
            panelSubData.Visible = false;
            panelsubAccount.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSubData.Visible == true)
                panelSubData.Visible = false;
            if (panelsubAccount.Visible == true)
                panelsubAccount.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void btnDataManaging_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubData);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new CitizenData());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // code

        }
        private void button8_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new VaccineData());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistics());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountSettings_Account());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubAccount);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountSettings_UserMnaging());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}

using PBL3.BLL;
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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            lb_username.Text = Provider.Instance.currentUser.Fullname;
        }


        private Form acctiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if(acctiveForm != null)
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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new VaccineRegistration());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountSettings_Account());
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
    }
}

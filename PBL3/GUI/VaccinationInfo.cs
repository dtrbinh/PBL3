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

namespace PBL3.GUI
{
    public partial class VaccinationInfo : Form
    {
        Citizen s_old = new Citizen();
        public VaccinationInfo()
        {
            InitializeComponent();
            InitCBB();
            GUI();
        }
        public void InitCBB()
        {
            cbbGender.Items.Add("Male");
            cbbGender.Items.Add("Female");
            cbbDoes.Items.Add("0");
            cbbDoes.Items.Add("1");
            cbbDoes.Items.Add("2");
            cbbDoes.Items.Add("3");
            cbbDoes.Items.Add("4");
        }
        public void GUI()
        {
            string cmnd = Provider.Instance.currentUser.CMND_CCCD;
            Citizen s = Provider.Instance.GetCitizen_By_CMND(cmnd);

            s_old = s; // dùng để undo

            txtCMND.Text = s.CMND_CCCD;
            txtPhone.Text = s.phone;
            txtFullname.Text = s.fullName;
            txtAddress.Text = s.address;
            if (s.gender)
            {
                cbbGender.SelectedIndex = 0;
            }
            else
            {
                cbbGender.SelectedIndex = 1;
            }
            dateTimePicker1.Value = s.birth;
            dateTimePicker2.Value = DateTime.Now;
            cbbDoes.SelectedItem = s.vaccination.ToString();

            cbbGender.Enabled = false;
            txtCMND.Enabled = false;
            txtFullname.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            cbbDoes.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbbGender.Enabled = true;
            txtFullname.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            dateTimePicker1.Enabled = true;
            cbbDoes.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VaccineRegistration vr = new VaccineRegistration();
            vr.Show();
        }

        public Citizen GetData()
        {
            Citizen s = new Citizen();

            s.CMND_CCCD = txtCMND.Text;
            s.fullName = txtFullname.Text;
            s.phone = txtPhone.Text;
            s.address = txtAddress.Text;
            s.birth = dateTimePicker1.Value;
            if (cbbGender.SelectedIndex == 0)
            {
                s.gender = true;
            }
            else
            {
                s.gender = false;
            }
            s.vaccination = Convert.ToInt32(cbbDoes.SelectedItem.ToString());
            return s;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (txtCMND.Text == "" || txtFullname.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || cbbGender.Text == "" || cbbDoes.Text == "")
            {
                MessageBox.Show("Please fill in all the information.", "NOTICE");
            }
            else
            {
                Citizen s = GetData();
                Provider.Instance.ExecuteEdit(s, txtCMND.Text);
            }

            cbbGender.Enabled = false;
            txtFullname.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbbDoes.Enabled = false;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtPhone.Text = s_old.phone;
            txtFullname.Text = s_old.fullName;
            txtAddress.Text = s_old.address;
            if (s_old.gender)
            {
                cbbGender.SelectedIndex = 0;
            }
            else
            {
                cbbGender.SelectedIndex = 1;
            }
            dateTimePicker1.Value = s_old.birth;
            cbbDoes.SelectedItem = s_old.vaccination.ToString();

            Provider.Instance.ExecuteEdit(s_old, txtCMND.Text);
        }
    }
}

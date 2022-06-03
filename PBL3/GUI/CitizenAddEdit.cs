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
    public partial class CitizenAddEdit : Form
    {
        public delegate void MyDelegate(string txt, string Address, string Does);
        public MyDelegate d;
        string CMND_CCCD = "";
        public CitizenAddEdit(string m)
        {
            InitializeComponent();
            CMND_CCCD = m;
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
            if (CMND_CCCD != "")
            {
                Citizen s = Provider.Instance.GetCitizen_By_CMND(CMND_CCCD);
                txtCMND.Text = s.CMND_CCCD;
                txtCMND.Enabled = false;
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
                dateTimePicker2.Value = s.regisDay;
                cbbDoes.SelectedItem = s.vaccination.ToString();
            }
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
            s.regisDay = dateTimePicker2.Value;
            s.vaccination = Convert.ToInt32(cbbDoes.SelectedItem.ToString());
            return s;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Citizen s = GetData();
            Provider.Instance.ExecuteAddEdit(s, CMND_CCCD);
            d("","","");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

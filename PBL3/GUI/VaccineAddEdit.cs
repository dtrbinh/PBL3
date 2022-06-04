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
    public partial class VaccineAddEdit : Form
    {
        public delegate void MyDelegate(string txt, string search);
        public MyDelegate d;
        string vaccine_name = "";
        public VaccineAddEdit(string n)
        {
            InitializeComponent();
            vaccine_name = n;
            GUI();
        }
        public void GUI()
        {
            if (vaccine_name != "")
            {
                Vaccine v = Provider.Instance.GetVaccine_By_Name(vaccine_name);
                txtVaccineName.Text = v.vaccineName;
                txtVaccineName.Enabled = false;
                txtQuanity.Text = v.quanity.ToString();
            }
        }
        public Vaccine GetData()
        {
            Vaccine v = new Vaccine();
            v.vaccineName = txtVaccineName.Text;
            v.quanity = Convert.ToInt32(txtQuanity.Text);
            return v;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Vaccine v = GetData();
            Provider.Instance.ExecuteAddEdit(v, vaccine_name);
            d("", "");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

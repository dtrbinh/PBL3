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
    public partial class VaccineRegistration : Form
    {
        public VaccineRegistration()
        {
            InitializeComponent();
            InitCBB();
            SetDose();
        }
        public void SetDose()
        {
            string cmnd = Provider.Instance.currentUser.CMND_CCCD;
            Citizen s = Provider.Instance.GetCitizen_By_CMND(cmnd);
            txtDose.Enabled = false;
            txtDose.Text = (s.vaccination + 1).ToString();
        }
        public void InitCBB()
        {           
            cbbVaccineType.Items.AddRange(Provider.Instance.GetCBB_Filter().ToArray());
            cbbVaccineType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _vaccinename = cbbVaccineType.SelectedItem.ToString();
            string cmnd = Provider.Instance.currentUser.CMND_CCCD;
            Citizen s = Provider.Instance.GetCitizen_By_CMND(cmnd);

            Registration r = new Registration();
            r.CMND_CCCD = s.CMND_CCCD;
            r.Dose = s.vaccination;
            r.vaccineName = _vaccinename;
            r.regisDay = DateTime.Now;
            r.State = false;

            Provider.Instance.ExecuteAdd(r);
            this.Close();
        }
    }
}

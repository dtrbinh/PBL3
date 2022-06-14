using PBL3.BLL;
using PBL3.DTO;
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
    public partial class RegistrationAddEdit : Form
    {
        public delegate void MyDelegate(string txt, string vaccineName, string vaccineState);
        public MyDelegate d;
        public string regisID;
        public RegistrationAddEdit()
        {
            InitializeComponent();
        }
        public RegistrationAddEdit(string _regisID)
        {
            regisID = _regisID;
            InitializeComponent();
            showData();
            initCBB();
        }
        private void initCBB()
        {
            cbbVaccineName.Items.AddRange(Provider.Instance.GetCBB_AllVaccineName().ToArray());
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saveEdit();
            this.Close();
        }
        private void saveEdit()
        {
            Registration r = Provider.Instance.GetRegistration_By_ID(regisID);
            r.vaccineName = cbbVaccineName.SelectedItem.ToString();
            r.State = txtState.Checked;
            Provider.Instance.ExecuteEdit(r);
            d("", "", "");
        }
        private void showData()
        {
            Registration r = Provider.Instance.GetRegistration_By_ID(regisID);
            txtCMND_CCCD.Text = r.CMND_CCCD;
            txtID.Text = r.regisId;
            txtDose.Text = r.Dose.ToString();
            txtRegistDate.Text = r.regisDay.ToString();
            txtCMND_CCCD.Enabled = false;
            txtID.Enabled = false;
            txtDose.Enabled = false;
            txtRegistDate.Enabled = false;
            cbbVaccineName.SelectedItem = r.vaccineName;
            txtState.Checked = r.State;
        }
    }
}

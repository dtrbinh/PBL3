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
                txtquantity.Text = v.quantity.ToString();
            }
        }
        public Vaccine GetData()
        {
            Vaccine v = new Vaccine();
            v.vaccineName = txtVaccineName.Text;
            v.quantity = Convert.ToInt32(txtquantity.Text);
            return v;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtVaccineName.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("Please fill in all the information");
            }
            else
            {
                Vaccine v = GetData();
                if (txtVaccineName.Enabled == true)
                {
                    if (Provider.Instance.CheckDuplicate_VaccineName(v.vaccineName) == false)
                    {
                        MessageBox.Show("Vaccine Name already existed!", "NOTICE");
                        txtVaccineName.Text = "";
                        txtVaccineName.Focus();          
                    }
                    else
                    {
                        Provider.Instance.ExecuteAdd(v, vaccine_name);
                        this.Close();
                    }
                }
                else
                {
                    Provider.Instance.ExecuteEdit(v, vaccine_name);
                    this.Close();
                }
                d("", "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3
{
    public partial class CitizenData : Form
    {
        public CitizenData()
        {
            InitializeComponent();
            ShowDGV("","","");
            InitCBB();
            cbbAddress.SelectedIndex = 0;
        }
        public void InitCBB()
        {
            cbbAddress.Items.Add("All");
            cbbDoes.Items.Add("All");
            cbbAddress.Items.AddRange(Provider.Instance.GetCBB_Address().ToArray());
            cbbDoes.Items.AddRange(Provider.Instance.GetCBB_Does().ToArray());
            cbbSort.Items.Add("Full Name");
            cbbSort.Items.Add("Address");
            cbbSort.SelectedIndex = 0;
        }
        public void ShowDGV(string txt, string Address = "", string Does = "")
        {
            dgv.DataSource = BLL.Provider.Instance.FilteredViews(txt, Address, Does).ToArray();
            // Modify DGVs Appearance
            dgv.Columns[0].HeaderText = "CMND/CCCD";
            dgv.Columns[1].HeaderText = "Full Name";
            dgv.Columns[2].HeaderText = "Gender";
            dgv.Columns[3].HeaderText = "Date of Birth";
            dgv.Columns[4].HeaderText = "Phone Number";
            dgv.Columns[5].HeaderText = "Address";
            dgv.Columns[6].HeaderText = "Lastest Vaccination Date";
            dgv.Columns[7].HeaderText = "Current Vaccination Status";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CitizenAddEdit f = new CitizenAddEdit("");
            f.d = new CitizenAddEdit.MyDelegate(ShowDGV);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string CMND = dgv.SelectedRows[0].Cells["CMND_CCCD"].Value.ToString();
                CitizenAddEdit f = new CitizenAddEdit(CMND);
                f.d = new CitizenAddEdit.MyDelegate(ShowDGV);
                f.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string CMND = "";
                foreach (DataGridViewRow i in dgv.SelectedRows)
                {
                    CMND = i.Cells["CMND_CCCD"].Value.ToString();
                }
                Provider.Instance.Delete_BLL(CMND);
            }
            ShowDGV(txtSearch.Text,cbbAddress.SelectedItem.ToString(), cbbDoes.SelectedItem.ToString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text, cbbAddress.SelectedItem.ToString(), cbbDoes.SelectedItem.ToString());
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbDoes.SelectedItem == null)
            {
                cbbDoes.SelectedIndex = 0;
            }
            ShowDGV(txtSearch.Text, cbbAddress.SelectedItem.ToString(), cbbDoes.SelectedItem.ToString());
        }

        private void cbbDoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text, cbbAddress.SelectedItem.ToString(), cbbDoes.SelectedItem.ToString());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Provider.Instance.Sort_BLL(txtSearch.Text, cbbAddress.SelectedItem.ToString(), cbbDoes.SelectedItem.ToString(), cbbSort.SelectedIndex);
        }
    }
}

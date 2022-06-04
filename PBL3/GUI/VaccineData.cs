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

namespace PBL3.GUI
{
    public partial class VaccineData : Form
    {
        public VaccineData()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(55, 54, 92);
            ShowDGV("", "");
            InitCBB();
            cbbFilter.SelectedIndex = 0;
        }

        public void InitCBB()
        {
            cbbFilter.Items.Add("All");
            cbbFilter.Items.AddRange(Provider.Instance.GetCBB_Filter().ToArray());
            cbbSort.Items.Add("Vaccine Name");
            cbbSort.Items.Add("Quanity");
            cbbSort.SelectedIndex = 0;
        }
        public void ShowDGV(string txt, string search = "")
        {
            dgv.DataSource = BLL.Provider.Instance.FilteredViews(txt, search).ToArray();
            // Modify DGVs Appearance
            dgv.Columns[0].HeaderText = "Vaccine Name";
            dgv.Columns[1].HeaderText = "Quanity";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VaccineAddEdit f = new VaccineAddEdit("");
            f.d = new VaccineAddEdit.MyDelegate(ShowDGV);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string name = dgv.SelectedRows[0].Cells["vaccineName"].Value.ToString();
                VaccineAddEdit f = new VaccineAddEdit(name);
                f.d = new VaccineAddEdit.MyDelegate(ShowDGV);
                f.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string name = "";
                foreach (DataGridViewRow i in dgv.SelectedRows)
                {
                    name = i.Cells["vaccineName"].Value.ToString();
                }
                Provider.Instance.Delete_BLL_Vaccine(name);
            }
            ShowDGV(cbbFilter.SelectedItem.ToString(), txtSearch.Text);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Provider.Instance.Sort_BLL(txtSearch.Text, cbbSort.SelectedIndex);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(cbbFilter.SelectedItem.ToString(), txtSearch.Text);
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV(cbbFilter.SelectedItem.ToString(), txtSearch.Text);
        }
    }
}


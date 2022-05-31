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
            ShowData("");
        }
        public void ShowData(string txt)
        {
            dgvVaccine.DataSource = Provider.Instance.GetAllVaccine(txt);
        }

    }
}

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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            chartDose.Series["Dose"].IsValueShownAsLabel = true;
            chartAge.Series["Age"].IsValueShownAsLabel = true;

            chartDose.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chartDose.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            chartAge.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chartAge.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
        }

       
    }
}

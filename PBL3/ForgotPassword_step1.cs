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
    public partial class ForgotPassword_step1 : Form
    {
        public ForgotPassword_step1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPassWord_step2 fg_2 = new ForgotPassWord_step2();
            fg_2.Show();
        }
    }
}

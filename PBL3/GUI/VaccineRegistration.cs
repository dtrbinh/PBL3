﻿using System;
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
using System.Runtime.InteropServices;

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

            string id_regis = DateTime.Now.ToString("hhmmtt") + cmnd;

            Registration r = new Registration(id_regis, cmnd, s.vaccination + 1, _vaccinename, DateTime.Now, false);
            Provider.Instance.ExecuteAdd(r);
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

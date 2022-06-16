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
            GUI();
            InitCBB();
        }

        public void GUI()
        {
            txtDesesInjected.Enabled = false;
            txtPreDay.Enabled = false;
            string cmnd = Provider.Instance.currentUser.CMND_CCCD;
            Citizen s = Provider.Instance.GetCitizen_By_CMND(cmnd);

            txtDesesInjected.Text = s.vaccination.ToString();

            if (s.vaccination == 0)
            {
                txtPreDay.Text = "";
            }
            else
            {
                foreach (Registration r in Provider.Instance.GetAll_Registration())
                {
                    if (r.CMND_CCCD == s.CMND_CCCD)
                    {
                        txtPreDay.Text = r.regisDay.ToString();
                        break;
                    }
                }
            }

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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string cmnd = Provider.Instance.currentUser.CMND_CCCD;
            bool flag = true;
            Registration check = new Registration();
            foreach (Registration i in Provider.Instance.GetRegistration_By_CMND(cmnd))
            {
                if (i.State)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    check = i;
                    break;
                }
            }
            if (flag)
            {
                string _vaccinename = cbbVaccineType.SelectedItem.ToString();
                Citizen s = Provider.Instance.GetCitizen_By_CMND(cmnd);
                string id_regis = DateTime.Now.ToString("hhmmss") + cmnd;
                Registration r = new Registration(id_regis, cmnd, s.vaccination + 1, _vaccinename, DateTime.Now, false);
                Provider.Instance.ExecuteAdd(r);
                MessageBox.Show("Registered successfully!\nRegistration ID: " + id_regis, "NOTICE");
            }
            else
            {
                MessageBox.Show("You can't register!\nBecause you have an pending registration.\nID: " + check.regisId, "NOTICE");
            }
        }
    }
}

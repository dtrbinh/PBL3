﻿
namespace PBL3
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.txt_rePassword = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reShowPassword = new System.Windows.Forms.Button();
            this.btn_showPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLabel2.Location = new System.Drawing.Point(119, 412);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(120, 19);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Return to Sign In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(87)))), ((int)(((byte)(201)))));
            this.btn_createAccount.FlatAppearance.BorderSize = 0;
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_createAccount.ForeColor = System.Drawing.Color.White;
            this.btn_createAccount.Location = new System.Drawing.Point(68, 337);
            this.btn_createAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(238, 35);
            this.btn_createAccount.TabIndex = 31;
            this.btn_createAccount.Text = "Create";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // txt_rePassword
            // 
            this.txt_rePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rePassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_rePassword.Location = new System.Drawing.Point(70, 281);
            this.txt_rePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rePassword.Multiline = true;
            this.txt_rePassword.Name = "txt_rePassword";
            this.txt_rePassword.PasswordChar = '*';
            this.txt_rePassword.Size = new System.Drawing.Size(206, 29);
            this.txt_rePassword.TabIndex = 30;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_username.Location = new System.Drawing.Point(70, 144);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(238, 29);
            this.txt_username.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Confirm password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(65, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_password.Location = new System.Drawing.Point(70, 214);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(206, 29);
            this.txt_password.TabIndex = 29;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cmnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cmnd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_cmnd.Location = new System.Drawing.Point(70, 66);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cmnd.Multiline = true;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(238, 29);
            this.txt_cmnd.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "CCCD/CMND";
            // 
            // btn_reShowPassword
            // 
            this.btn_reShowPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btn_reShowPassword.FlatAppearance.BorderSize = 0;
            this.btn_reShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_reShowPassword.Image")));
            this.btn_reShowPassword.Location = new System.Drawing.Point(276, 281);
            this.btn_reShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reShowPassword.Name = "btn_reShowPassword";
            this.btn_reShowPassword.Size = new System.Drawing.Size(32, 29);
            this.btn_reShowPassword.TabIndex = 39;
            this.btn_reShowPassword.UseVisualStyleBackColor = false;
            this.btn_reShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_reShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btn_showPassword.FlatAppearance.BorderSize = 0;
            this.btn_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showPassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_showPassword.Image")));
            this.btn_showPassword.Location = new System.Drawing.Point(276, 214);
            this.btn_showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.Size = new System.Drawing.Size(32, 29);
            this.btn_showPassword.TabIndex = 38;
            this.btn_showPassword.UseVisualStyleBackColor = false;
            this.btn_showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 464);
            this.Controls.Add(this.btn_reShowPassword);
            this.Controls.Add(this.btn_showPassword);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.txt_rePassword);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.TextBox txt_rePassword;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_showPassword;
        private System.Windows.Forms.Button btn_reShowPassword;
    }
}
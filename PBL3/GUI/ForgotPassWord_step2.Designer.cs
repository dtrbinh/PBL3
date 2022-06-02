
namespace PBL3
{
    partial class ForgotPassWord_step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassWord_step2));
            this.btn_confirmChangePassword = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reShowPassword = new System.Windows.Forms.Button();
            this.txt_rePassword = new System.Windows.Forms.TextBox();
            this.btn_showPassword = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_confirmChangePassword
            // 
            this.btn_confirmChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(87)))), ((int)(((byte)(201)))));
            this.btn_confirmChangePassword.FlatAppearance.BorderSize = 0;
            this.btn_confirmChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmChangePassword.ForeColor = System.Drawing.Color.White;
            this.btn_confirmChangePassword.Location = new System.Drawing.Point(37, 201);
            this.btn_confirmChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirmChangePassword.Name = "btn_confirmChangePassword";
            this.btn_confirmChangePassword.Size = new System.Drawing.Size(280, 43);
            this.btn_confirmChangePassword.TabIndex = 43;
            this.btn_confirmChangePassword.Text = "Confirm";
            this.btn_confirmChangePassword.UseVisualStyleBackColor = false;
            this.btn_confirmChangePassword.Click += new System.EventHandler(this.btn_confirmChangePassword_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "New Password";
            // 
            // btn_reShowPassword
            // 
            this.btn_reShowPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btn_reShowPassword.FlatAppearance.BorderSize = 0;
            this.btn_reShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_reShowPassword.Image")));
            this.btn_reShowPassword.Location = new System.Drawing.Point(275, 137);
            this.btn_reShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reShowPassword.Name = "btn_reShowPassword";
            this.btn_reShowPassword.Size = new System.Drawing.Size(43, 36);
            this.btn_reShowPassword.TabIndex = 49;
            this.btn_reShowPassword.UseVisualStyleBackColor = false;
            this.btn_reShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_reShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // txt_rePassword
            // 
            this.txt_rePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rePassword.Location = new System.Drawing.Point(35, 137);
            this.txt_rePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rePassword.Multiline = true;
            this.txt_rePassword.Name = "txt_rePassword";
            this.txt_rePassword.PasswordChar = '*';
            this.txt_rePassword.Size = new System.Drawing.Size(240, 36);
            this.txt_rePassword.TabIndex = 47;
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btn_showPassword.FlatAppearance.BorderSize = 0;
            this.btn_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showPassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_showPassword.Image")));
            this.btn_showPassword.Location = new System.Drawing.Point(275, 54);
            this.btn_showPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.Size = new System.Drawing.Size(43, 36);
            this.btn_showPassword.TabIndex = 52;
            this.btn_showPassword.UseVisualStyleBackColor = false;
            this.btn_showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(35, 54);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(240, 36);
            this.txt_password.TabIndex = 50;
            // 
            // ForgotPassWord_step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(352, 284);
            this.Controls.Add(this.btn_showPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_reShowPassword);
            this.Controls.Add(this.txt_rePassword);
            this.Controls.Add(this.btn_confirmChangePassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassWord_step2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassWord_step2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmChangePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reShowPassword;
        private System.Windows.Forms.TextBox txt_rePassword;
        private System.Windows.Forms.Button btn_showPassword;
        private System.Windows.Forms.TextBox txt_password;
    }
}
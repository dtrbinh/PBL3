
namespace PBL3
{
    partial class ForgotPassword_step1
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_checkUsernameValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_username.Location = new System.Drawing.Point(35, 54);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(283, 36);
            this.txt_username.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLabel2.Location = new System.Drawing.Point(95, 178);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(143, 21);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Return to Sign In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_checkUsernameValid
            // 
            this.btn_checkUsernameValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(87)))), ((int)(((byte)(201)))));
            this.btn_checkUsernameValid.FlatAppearance.BorderSize = 0;
            this.btn_checkUsernameValid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkUsernameValid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_checkUsernameValid.ForeColor = System.Drawing.Color.White;
            this.btn_checkUsernameValid.Location = new System.Drawing.Point(35, 113);
            this.btn_checkUsernameValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_checkUsernameValid.Name = "btn_checkUsernameValid";
            this.btn_checkUsernameValid.Size = new System.Drawing.Size(283, 43);
            this.btn_checkUsernameValid.TabIndex = 39;
            this.btn_checkUsernameValid.Text = "Check";
            this.btn_checkUsernameValid.UseVisualStyleBackColor = false;
            this.btn_checkUsernameValid.Click += new System.EventHandler(this.btn_checkUsernameValid_Click);
            // 
            // ForgotPassword_step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(352, 225);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btn_checkUsernameValid);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword_step1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword_step1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_checkUsernameValid;
    }
}

namespace PBL3
{
    partial class RegistrationAddEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCMND_CCCD = new System.Windows.Forms.TextBox();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtRegistDate = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbbVaccineName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND/CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vaccine Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(244, 100);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtCMND_CCCD
            // 
            this.txtCMND_CCCD.Location = new System.Drawing.Point(244, 136);
            this.txtCMND_CCCD.Name = "txtCMND_CCCD";
            this.txtCMND_CCCD.Size = new System.Drawing.Size(100, 22);
            this.txtCMND_CCCD.TabIndex = 7;
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(244, 172);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(100, 22);
            this.txtDose.TabIndex = 8;
            // 
            // txtRegistDate
            // 
            this.txtRegistDate.Location = new System.Drawing.Point(244, 206);
            this.txtRegistDate.Name = "txtRegistDate";
            this.txtRegistDate.Size = new System.Drawing.Size(100, 22);
            this.txtRegistDate.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.Location = new System.Drawing.Point(528, 138);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 21);
            this.txtState.TabIndex = 11;
            this.txtState.Text = "Vaccinated";
            this.txtState.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(396, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbbVaccineName
            // 
            this.cbbVaccineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVaccineName.FormattingEnabled = true;
            this.cbbVaccineName.Location = new System.Drawing.Point(528, 97);
            this.cbbVaccineName.Name = "cbbVaccineName";
            this.cbbVaccineName.Size = new System.Drawing.Size(121, 24);
            this.cbbVaccineName.TabIndex = 14;
            // 
            // RegistrationAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbVaccineName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtRegistDate);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.txtCMND_CCCD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationAddEdit";
            this.Text = "RegistrationAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCMND_CCCD;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtRegistDate;
        private System.Windows.Forms.CheckBox txtState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbbVaccineName;
    }
}
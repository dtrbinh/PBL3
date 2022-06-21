
namespace PBL3
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDose = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDose
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDose.ChartAreas.Add(chartArea1);
            this.chartDose.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartDose.Legends.Add(legend1);
            this.chartDose.Location = new System.Drawing.Point(0, 0);
            this.chartDose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDose.Name = "chartDose";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dose";
            this.chartDose.Series.Add(series1);
            this.chartDose.Size = new System.Drawing.Size(467, 539);
            this.chartDose.TabIndex = 0;
            this.chartDose.Text = "chart1";
            // 
            // chartAge
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea2);
            this.chartAge.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chartAge.Legends.Add(legend2);
            this.chartAge.Location = new System.Drawing.Point(467, 0);
            this.chartAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartAge.Name = "chartAge";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Age";
            this.chartAge.Series.Add(series2);
            this.chartAge.Size = new System.Drawing.Size(468, 539);
            this.chartAge.TabIndex = 1;
            this.chartAge.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(935, 539);
            this.Controls.Add(this.chartAge);
            this.Controls.Add(this.chartDose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartDose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
    }
}
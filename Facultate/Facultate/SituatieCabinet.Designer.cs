namespace Cabinet_Medical
{
    partial class SituatieCabinet
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
            this.columnMedieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VechimeMedie = new System.Windows.Forms.ToolStripMenuItem();
            this.graficVechime = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.columnMedieChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnMedieChart
            // 
            this.columnMedieChart.BackColor = System.Drawing.Color.Snow;
            chartArea1.Name = "ChartArea1";
            this.columnMedieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.columnMedieChart.Legends.Add(legend1);
            this.columnMedieChart.Location = new System.Drawing.Point(15, 84);
            this.columnMedieChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.columnMedieChart.Name = "columnMedieChart";
            this.columnMedieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vechimea medie a fiecarui medic";
            this.columnMedieChart.Series.Add(series1);
            this.columnMedieChart.Size = new System.Drawing.Size(937, 244);
            this.columnMedieChart.TabIndex = 0;
            this.columnMedieChart.Text = "Medie Studenti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VechimeMedie,
            this.graficVechime});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VechimeMedie
            // 
            this.VechimeMedie.BackColor = System.Drawing.Color.DarkRed;
            this.VechimeMedie.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VechimeMedie.Name = "VechimeMedie";
            this.VechimeMedie.Size = new System.Drawing.Size(139, 22);
            this.VechimeMedie.Text = "Vechime Medie";
            this.VechimeMedie.Click += new System.EventHandler(this.Vechime_Medie);
            // 
            // graficVechime
            // 
            this.graficVechime.BackColor = System.Drawing.Color.DarkRed;
            this.graficVechime.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficVechime.Name = "graficVechime";
            this.graficVechime.Size = new System.Drawing.Size(143, 22);
            this.graficVechime.Text = "Grafic vechime";
            this.graficVechime.Click += new System.EventHandler(this.Grafic_Vechime);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SituatieCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(959, 439);
            this.Controls.Add(this.columnMedieChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SituatieCabinet";
            this.Text = "SituatieCabinet";
            this.Load += new System.EventHandler(this.SituatieCabinetMedical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnMedieChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart columnMedieChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VechimeMedie;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem graficVechime;
    }
}
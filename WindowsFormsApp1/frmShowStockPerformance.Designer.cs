namespace WindowsFormsApp1
{
    partial class frmShowStockPerformance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.radioBest = new System.Windows.Forms.RadioButton();
            this.radioWorst = new System.Windows.Forms.RadioButton();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // radioBest
            // 
            this.radioBest.AutoSize = true;
            this.radioBest.Checked = true;
            this.radioBest.Location = new System.Drawing.Point(433, 39);
            this.radioBest.Name = "radioBest";
            this.radioBest.Size = new System.Drawing.Size(80, 17);
            this.radioBest.TabIndex = 1;
            this.radioBest.TabStop = true;
            this.radioBest.Text = "Best Sellers";
            this.radioBest.UseVisualStyleBackColor = true;
            // 
            // radioWorst
            // 
            this.radioWorst.AutoSize = true;
            this.radioWorst.Location = new System.Drawing.Point(520, 39);
            this.radioWorst.Name = "radioWorst";
            this.radioWorst.Size = new System.Drawing.Size(87, 17);
            this.radioWorst.TabIndex = 2;
            this.radioWorst.TabStop = true;
            this.radioWorst.Text = "Worst Sellers";
            this.radioWorst.UseVisualStyleBackColor = true;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(70, 39);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(216, 21);
            this.cboYear.TabIndex = 3;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // chtData
            // 
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(12, 93);
            this.chtData.Name = "chtData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(845, 463);
            this.chtData.TabIndex = 4;
            this.chtData.Text = "chart1";
            // 
            // frmShowStockPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 568);
            this.Controls.Add(this.chtData);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.radioWorst);
            this.Controls.Add(this.radioBest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmShowStockPerformance";
            this.Text = "Show Worst Sellers";
            this.Load += new System.EventHandler(this.frmShowStockPerformance_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.RadioButton radioBest;
        private System.Windows.Forms.RadioButton radioWorst;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
    }
}
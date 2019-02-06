namespace WindowsFormsApp1
{
    partial class frmPaySupplier
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lstBoxPaySupplier = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupplierBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.btnPaySupplier = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
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
            // lstBoxPaySupplier
            // 
            this.lstBoxPaySupplier.FormattingEnabled = true;
            this.lstBoxPaySupplier.HorizontalScrollbar = true;
            this.lstBoxPaySupplier.Items.AddRange(new object[] {
            "1  Diageo   No.4   Main Street   Tralee   Co.Kerry   066 123456   Diageo@diageosa" +
                "les.com   1256.00 ",
            "2  Heineken   No.5   Main Street   Killarney   Co.Kerry   066 654321   Heineken@h" +
                "einekensales.com   6521.00 ",
            "3  Cash & Carry   No.6   Main Street   Killorglin   Co.Kerry   066 657483   C&C@c" +
                "ashandcarrysales.com   356.00 "});
            this.lstBoxPaySupplier.Location = new System.Drawing.Point(39, 43);
            this.lstBoxPaySupplier.Name = "lstBoxPaySupplier";
            this.lstBoxPaySupplier.ScrollAlwaysVisible = true;
            this.lstBoxPaySupplier.Size = new System.Drawing.Size(424, 134);
            this.lstBoxPaySupplier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Balance";
            // 
            // lblSupplierBalance
            // 
            this.lblSupplierBalance.AutoSize = true;
            this.lblSupplierBalance.Location = new System.Drawing.Point(200, 231);
            this.lblSupplierBalance.Name = "lblSupplierBalance";
            this.lblSupplierBalance.Size = new System.Drawing.Size(46, 13);
            this.lblSupplierBalance.TabIndex = 3;
            this.lblSupplierBalance.Text = "1264.65";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount to Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(203, 296);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(124, 20);
            this.txtAmountToPay.TabIndex = 5;
            // 
            // btnPaySupplier
            // 
            this.btnPaySupplier.Location = new System.Drawing.Point(97, 362);
            this.btnPaySupplier.Name = "btnPaySupplier";
            this.btnPaySupplier.Size = new System.Drawing.Size(245, 40);
            this.btnPaySupplier.TabIndex = 6;
            this.btnPaySupplier.Text = "Pay Supplier";
            this.btnPaySupplier.UseVisualStyleBackColor = true;
            // 
            // frmPaySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.btnPaySupplier);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSupplierBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxPaySupplier);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaySupplier";
            this.Text = "Pay Supplier";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ListBox lstBoxPaySupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupplierBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Button btnPaySupplier;
    }
}
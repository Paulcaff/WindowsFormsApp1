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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.btnPaySupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.grpPaySupplier = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.grpPaySupplier.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount to Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(230, 112);
            this.txtAmountToPay.MaxLength = 7;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(158, 20);
            this.txtAmountToPay.TabIndex = 5;
            // 
            // btnPaySupplier
            // 
            this.btnPaySupplier.Location = new System.Drawing.Point(83, 156);
            this.btnPaySupplier.Name = "btnPaySupplier";
            this.btnPaySupplier.Size = new System.Drawing.Size(245, 40);
            this.btnPaySupplier.TabIndex = 6;
            this.btnPaySupplier.Text = "Pay Supplier";
            this.btnPaySupplier.UseVisualStyleBackColor = true;
            this.btnPaySupplier.Click += new System.EventHandler(this.btnPaySupplier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Supplier";
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Location = new System.Drawing.Point(194, 50);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(144, 20);
            this.txtSearchSupplier.TabIndex = 8;
            this.txtSearchSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(12, 78);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(495, 150);
            this.grdData.TabIndex = 9;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(230, 76);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(158, 20);
            this.txtBalance.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Location = new System.Drawing.Point(230, 43);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(158, 20);
            this.txtSupplierName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Supplier Id";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(230, 8);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(158, 20);
            this.txtSupplierId.TabIndex = 14;
            // 
            // grpPaySupplier
            // 
            this.grpPaySupplier.Controls.Add(this.txtSupplierId);
            this.grpPaySupplier.Controls.Add(this.label5);
            this.grpPaySupplier.Controls.Add(this.txtSupplierName);
            this.grpPaySupplier.Controls.Add(this.label4);
            this.grpPaySupplier.Controls.Add(this.txtBalance);
            this.grpPaySupplier.Controls.Add(this.btnPaySupplier);
            this.grpPaySupplier.Controls.Add(this.txtAmountToPay);
            this.grpPaySupplier.Controls.Add(this.label2);
            this.grpPaySupplier.Controls.Add(this.label1);
            this.grpPaySupplier.Location = new System.Drawing.Point(12, 234);
            this.grpPaySupplier.Name = "grpPaySupplier";
            this.grpPaySupplier.Size = new System.Drawing.Size(495, 214);
            this.grpPaySupplier.TabIndex = 15;
            this.grpPaySupplier.TabStop = false;
            this.grpPaySupplier.Text = "Supplier Detail";
            // 
            // frmPaySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.grpPaySupplier);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaySupplier";
            this.Text = "Pay Supplier";
            this.Load += new System.EventHandler(this.frmPaySupplier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.grpPaySupplier.ResumeLayout(false);
            this.grpPaySupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Button btnPaySupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.GroupBox grpPaySupplier;
    }
}
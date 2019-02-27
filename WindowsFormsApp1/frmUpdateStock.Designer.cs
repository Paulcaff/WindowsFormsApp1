namespace WindowsFormsApp1
{
    partial class frmUpdateStock
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
            this.frmBack = new System.Windows.Forms.ToolStripMenuItem();
            this.frmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.grpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmBack,
            this.frmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmBack
            // 
            this.frmBack.Name = "frmBack";
            this.frmBack.Size = new System.Drawing.Size(44, 20);
            this.frmBack.Text = "Back";
            this.frmBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmExit
            // 
            this.frmExit.Name = "frmExit";
            this.frmExit.Size = new System.Drawing.Size(37, 20);
            this.frmExit.Text = "Exit";
            this.frmExit.Click += new System.EventHandler(this.frmExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Supplier Id";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(177, 60);
            this.txtStockName.MaxLength = 20;
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(182, 20);
            this.txtStockName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(176, 95);
            this.txtDescription.MaxLength = 25;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(178, 125);
            this.txtAmount.MaxLength = 4;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(178, 156);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(178, 189);
            this.txtSupplier.MaxLength = 4;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(181, 20);
            this.txtSupplier.TabIndex = 10;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(109, 262);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(181, 39);
            this.btnUpdateStock.TabIndex = 11;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(41, 80);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.Size = new System.Drawing.Size(399, 80);
            this.grdData.TabIndex = 12;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search Stock";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(212, 47);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stock Id";
            // 
            // txtStockId
            // 
            this.txtStockId.Enabled = false;
            this.txtStockId.Location = new System.Drawing.Point(177, 25);
            this.txtStockId.MaxLength = 4;
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(181, 20);
            this.txtStockId.TabIndex = 16;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.txtStockId);
            this.grpStock.Controls.Add(this.label7);
            this.grpStock.Controls.Add(this.txtSupplier);
            this.grpStock.Controls.Add(this.txtPrice);
            this.grpStock.Controls.Add(this.btnUpdateStock);
            this.grpStock.Controls.Add(this.txtAmount);
            this.grpStock.Controls.Add(this.txtDescription);
            this.grpStock.Controls.Add(this.txtStockName);
            this.grpStock.Controls.Add(this.label5);
            this.grpStock.Controls.Add(this.label4);
            this.grpStock.Controls.Add(this.label3);
            this.grpStock.Controls.Add(this.label2);
            this.grpStock.Controls.Add(this.label1);
            this.grpStock.Location = new System.Drawing.Point(41, 166);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(399, 307);
            this.grpStock.TabIndex = 17;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock Details";
            // 
            // frmUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 503);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUpdateStock";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.frmUpdateStock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmBack;
        private System.Windows.Forms.ToolStripMenuItem frmExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.GroupBox grpStock;
    }
}
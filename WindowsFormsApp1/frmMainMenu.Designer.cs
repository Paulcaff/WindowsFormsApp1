namespace WindowsFormsApp1
{
    partial class frmMainMenu
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
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceiveOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseSupplierAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaySuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowBestSellers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowWorstSellers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStock,
            this.mnuUpdateStock,
            this.mnuRemoveStock});
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "Stock";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuAddStock
            // 
            this.mnuAddStock.Name = "mnuAddStock";
            this.mnuAddStock.Size = new System.Drawing.Size(149, 22);
            this.mnuAddStock.Text = "Add Stock";
            this.mnuAddStock.Click += new System.EventHandler(this.mnuAddStock_Click);
            // 
            // mnuUpdateStock
            // 
            this.mnuUpdateStock.Name = "mnuUpdateStock";
            this.mnuUpdateStock.Size = new System.Drawing.Size(149, 22);
            this.mnuUpdateStock.Text = "Update Stock";
            this.mnuUpdateStock.Click += new System.EventHandler(this.mnuUpdateStock_Click);
            // 
            // mnuRemoveStock
            // 
            this.mnuRemoveStock.Name = "mnuRemoveStock";
            this.mnuRemoveStock.Size = new System.Drawing.Size(149, 22);
            this.mnuRemoveStock.Text = "Remove Stock";
            this.mnuRemoveStock.Click += new System.EventHandler(this.mnuRemoveStock_Click);
            // 
            // mnuOrders
            // 
            this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlaceOrder,
            this.mnuReceiveOrder,
            this.mnuCancelOrder,
            this.mnuReturnStock});
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(54, 20);
            this.mnuOrders.Text = "Orders";
            // 
            // mnuPlaceOrder
            // 
            this.mnuPlaceOrder.Name = "mnuPlaceOrder";
            this.mnuPlaceOrder.Size = new System.Drawing.Size(147, 22);
            this.mnuPlaceOrder.Text = "Place Order";
            this.mnuPlaceOrder.Click += new System.EventHandler(this.mnuPlaceOrder_Click);
            // 
            // mnuReceiveOrder
            // 
            this.mnuReceiveOrder.Name = "mnuReceiveOrder";
            this.mnuReceiveOrder.Size = new System.Drawing.Size(147, 22);
            this.mnuReceiveOrder.Text = "Receive Order";
            this.mnuReceiveOrder.Click += new System.EventHandler(this.mnuReceiveOrder_Click);
            // 
            // mnuCancelOrder
            // 
            this.mnuCancelOrder.Name = "mnuCancelOrder";
            this.mnuCancelOrder.Size = new System.Drawing.Size(147, 22);
            this.mnuCancelOrder.Text = "Cancel Order";
            this.mnuCancelOrder.Click += new System.EventHandler(this.mnuCancelOrder_Click);
            // 
            // mnuReturnStock
            // 
            this.mnuReturnStock.Name = "mnuReturnStock";
            this.mnuReturnStock.Size = new System.Drawing.Size(147, 22);
            this.mnuReturnStock.Text = "Return Stock";
            this.mnuReturnStock.Click += new System.EventHandler(this.mnuReturnStock_Click);
            // 
            // mnuSuppliers
            // 
            this.mnuSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddSuppliers,
            this.mnuUpdateSuppliers,
            this.mnuCloseSupplierAccount,
            this.mnuPaySuppliers});
            this.mnuSuppliers.Name = "mnuSuppliers";
            this.mnuSuppliers.Size = new System.Drawing.Size(67, 20);
            this.mnuSuppliers.Text = "Suppliers";
            // 
            // mnuAddSuppliers
            // 
            this.mnuAddSuppliers.Name = "mnuAddSuppliers";
            this.mnuAddSuppliers.Size = new System.Drawing.Size(197, 22);
            this.mnuAddSuppliers.Text = "Add Suppliers";
            this.mnuAddSuppliers.Click += new System.EventHandler(this.mnuAddSuppliers_Click);
            // 
            // mnuUpdateSuppliers
            // 
            this.mnuUpdateSuppliers.Name = "mnuUpdateSuppliers";
            this.mnuUpdateSuppliers.Size = new System.Drawing.Size(197, 22);
            this.mnuUpdateSuppliers.Text = "Update Suppliers";
            this.mnuUpdateSuppliers.Click += new System.EventHandler(this.mnuUpdateSuppliers_Click);
            // 
            // mnuCloseSupplierAccount
            // 
            this.mnuCloseSupplierAccount.Name = "mnuCloseSupplierAccount";
            this.mnuCloseSupplierAccount.Size = new System.Drawing.Size(197, 22);
            this.mnuCloseSupplierAccount.Text = "Close Supplier Account";
            this.mnuCloseSupplierAccount.Click += new System.EventHandler(this.mnuCloseSupplierAccount_Click);
            // 
            // mnuPaySuppliers
            // 
            this.mnuPaySuppliers.Name = "mnuPaySuppliers";
            this.mnuPaySuppliers.Size = new System.Drawing.Size(197, 22);
            this.mnuPaySuppliers.Text = "Pay Suppliers";
            this.mnuPaySuppliers.Click += new System.EventHandler(this.mnuPaySuppliers_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowBestSellers,
            this.mnuShowWorstSellers});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // mnuShowBestSellers
            // 
            this.mnuShowBestSellers.Name = "mnuShowBestSellers";
            this.mnuShowBestSellers.Size = new System.Drawing.Size(206, 22);
            this.mnuShowBestSellers.Text = "Yearly Revenue Analysis";
            this.mnuShowBestSellers.Click += new System.EventHandler(this.mnuShowBestSellers_Click);
            // 
            // mnuShowWorstSellers
            // 
            this.mnuShowWorstSellers.Name = "mnuShowWorstSellers";
            this.mnuShowWorstSellers.Size = new System.Drawing.Size(206, 22);
            this.mnuShowWorstSellers.Text = "Show Stock Performance";
            this.mnuShowWorstSellers.Click += new System.EventHandler(this.mnuShowWorstSellers_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStock,
            this.mnuOrders,
            this.mnuSuppliers,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "PubSpace";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStock;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateStock;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveStock;
        private System.Windows.Forms.ToolStripMenuItem mnuOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuPlaceOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuReceiveOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnStock;
        private System.Windows.Forms.ToolStripMenuItem mnuSuppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSuppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateSuppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseSupplierAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuPaySuppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuShowBestSellers;
        private System.Windows.Forms.ToolStripMenuItem mnuShowWorstSellers;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
    }
}


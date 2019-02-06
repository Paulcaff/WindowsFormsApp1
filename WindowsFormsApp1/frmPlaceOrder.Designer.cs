namespace WindowsFormsApp1
{
    partial class frmPlaceOrder
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
            this.lstBoxPlaceOrderSupplier = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxPlaceOrderStock = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountOrder = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Supplier You Wish To Order Off";
            // 
            // lstBoxPlaceOrderSupplier
            // 
            this.lstBoxPlaceOrderSupplier.FormattingEnabled = true;
            this.lstBoxPlaceOrderSupplier.Items.AddRange(new object[] {
            "1\tDiageo",
            "2\tHeineken",
            "3\tCash and Carry"});
            this.lstBoxPlaceOrderSupplier.Location = new System.Drawing.Point(90, 74);
            this.lstBoxPlaceOrderSupplier.Name = "lstBoxPlaceOrderSupplier";
            this.lstBoxPlaceOrderSupplier.ScrollAlwaysVisible = true;
            this.lstBoxPlaceOrderSupplier.Size = new System.Drawing.Size(318, 56);
            this.lstBoxPlaceOrderSupplier.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select The Stock Item You want to Order";
            // 
            // lstBoxPlaceOrderStock
            // 
            this.lstBoxPlaceOrderStock.FormattingEnabled = true;
            this.lstBoxPlaceOrderStock.Items.AddRange(new object[] {
            "1 Guinness",
            "2 Carlsberg",
            "3 Hop House 13",
            "4 Rockshore",
            "5 Miller",
            "6 Stella Cidre",
            "7 Pure Brew(Non Alcoholic)"});
            this.lstBoxPlaceOrderStock.Location = new System.Drawing.Point(91, 204);
            this.lstBoxPlaceOrderStock.Name = "lstBoxPlaceOrderStock";
            this.lstBoxPlaceOrderStock.ScrollAlwaysVisible = true;
            this.lstBoxPlaceOrderStock.Size = new System.Drawing.Size(318, 108);
            this.lstBoxPlaceOrderStock.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount to Order";
            // 
            // txtAmountOrder
            // 
            this.txtAmountOrder.Location = new System.Drawing.Point(276, 359);
            this.txtAmountOrder.Name = "txtAmountOrder";
            this.txtAmountOrder.Size = new System.Drawing.Size(122, 20);
            this.txtAmountOrder.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(123, 397);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(252, 41);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtAmountOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBoxPlaceOrderStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoxPlaceOrderSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlaceOrder";
            this.Text = "Place Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxPlaceOrderSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxPlaceOrderStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountOrder;
        private System.Windows.Forms.Button btnAddToCart;
    }
}
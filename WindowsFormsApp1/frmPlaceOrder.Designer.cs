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
            this.grdDataSupp = new System.Windows.Forms.DataGridView();
            this.grpStockSelection = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdDataStock = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtAmountOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataSupp)).BeginInit();
            this.grpStockSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataStock)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            this.label1.Location = new System.Drawing.Point(144, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Supplier You Wish To Order Off";
            // 
            // grdDataSupp
            // 
            this.grdDataSupp.AllowUserToAddRows = false;
            this.grdDataSupp.AllowUserToDeleteRows = false;
            this.grdDataSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataSupp.Location = new System.Drawing.Point(80, 96);
            this.grdDataSupp.Name = "grdDataSupp";
            this.grdDataSupp.ReadOnly = true;
            this.grdDataSupp.Size = new System.Drawing.Size(458, 150);
            this.grdDataSupp.TabIndex = 8;
            this.grdDataSupp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataSupp_CellClick);
            // 
            // grpStockSelection
            // 
            this.grpStockSelection.Controls.Add(this.btnFinish);
            this.grpStockSelection.Controls.Add(this.txtBalance);
            this.grpStockSelection.Controls.Add(this.label5);
            this.grpStockSelection.Controls.Add(this.txtPrice);
            this.grpStockSelection.Controls.Add(this.label4);
            this.grpStockSelection.Controls.Add(this.grdDataStock);
            this.grpStockSelection.Controls.Add(this.btnAddToCart);
            this.grpStockSelection.Controls.Add(this.txtAmountOrder);
            this.grpStockSelection.Controls.Add(this.label3);
            this.grpStockSelection.Controls.Add(this.label2);
            this.grpStockSelection.Location = new System.Drawing.Point(12, 266);
            this.grpStockSelection.Name = "grpStockSelection";
            this.grpStockSelection.Size = new System.Drawing.Size(573, 355);
            this.grpStockSelection.TabIndex = 11;
            this.grpStockSelection.TabStop = false;
            this.grpStockSelection.Text = "Order Stock";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(355, 312);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(170, 42);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(302, 274);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(117, 20);
            this.txtBalance.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Balance";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(426, 228);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price per Item";
            // 
            // grdDataStock
            // 
            this.grdDataStock.AllowUserToAddRows = false;
            this.grdDataStock.AllowUserToDeleteRows = false;
            this.grdDataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataStock.Location = new System.Drawing.Point(68, 57);
            this.grdDataStock.Name = "grdDataStock";
            this.grdDataStock.ReadOnly = true;
            this.grdDataStock.Size = new System.Drawing.Size(458, 150);
            this.grdDataStock.TabIndex = 9;
            this.grdDataStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataStock_CellClick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(68, 314);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(176, 41);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtAmountOrder
            // 
            this.txtAmountOrder.Location = new System.Drawing.Point(177, 228);
            this.txtAmountOrder.Name = "txtAmountOrder";
            this.txtAmountOrder.Size = new System.Drawing.Size(122, 20);
            this.txtAmountOrder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount to Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select The Stock Item You want to Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 14;
            this.label8.Visible = false;
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 634);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpStockSelection);
            this.Controls.Add(this.grdDataSupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlaceOrder";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataSupp)).EndInit();
            this.grpStockSelection.ResumeLayout(false);
            this.grpStockSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDataSupp;
        private System.Windows.Forms.GroupBox grpStockSelection;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdDataStock;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtAmountOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
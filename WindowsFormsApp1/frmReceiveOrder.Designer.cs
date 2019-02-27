namespace WindowsFormsApp1
{
    partial class frmReceiveOrder
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
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.grdDataSuppliers = new System.Windows.Forms.DataGridView();
            this.grdDataOrder = new System.Windows.Forms.DataGridView();
            this.grdDataReceive = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.NumericUpDown();
            this.txtOrdered = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Location = new System.Drawing.Point(153, 485);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(194, 38);
            this.btnReceiveOrder.TabIndex = 6;
            this.btnReceiveOrder.Text = "Update Files";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // grdDataSuppliers
            // 
            this.grdDataSuppliers.AllowUserToAddRows = false;
            this.grdDataSuppliers.AllowUserToDeleteRows = false;
            this.grdDataSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataSuppliers.Location = new System.Drawing.Point(65, 39);
            this.grdDataSuppliers.Name = "grdDataSuppliers";
            this.grdDataSuppliers.ReadOnly = true;
            this.grdDataSuppliers.Size = new System.Drawing.Size(304, 89);
            this.grdDataSuppliers.TabIndex = 7;
            this.grdDataSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataSuppliers_CellClick);
            // 
            // grdDataOrder
            // 
            this.grdDataOrder.AllowUserToAddRows = false;
            this.grdDataOrder.AllowUserToDeleteRows = false;
            this.grdDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataOrder.Location = new System.Drawing.Point(65, 143);
            this.grdDataOrder.Name = "grdDataOrder";
            this.grdDataOrder.ReadOnly = true;
            this.grdDataOrder.Size = new System.Drawing.Size(415, 80);
            this.grdDataOrder.TabIndex = 8;
            this.grdDataOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataOrder_CellClick);
            // 
            // grdDataReceive
            // 
            this.grdDataReceive.AllowUserToAddRows = false;
            this.grdDataReceive.AllowUserToDeleteRows = false;
            this.grdDataReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataReceive.Location = new System.Drawing.Point(65, 243);
            this.grdDataReceive.Name = "grdDataReceive";
            this.grdDataReceive.ReadOnly = true;
            this.grdDataReceive.Size = new System.Drawing.Size(304, 150);
            this.grdDataReceive.TabIndex = 9;
            this.grdDataReceive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataReceive_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(200, 444);
            this.txtReceived.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(90, 20);
            this.txtReceived.TabIndex = 11;
            this.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrdered
            // 
            this.txtOrdered.Enabled = false;
            this.txtOrdered.Location = new System.Drawing.Point(200, 408);
            this.txtOrdered.Name = "txtOrdered";
            this.txtOrdered.Size = new System.Drawing.Size(90, 20);
            this.txtOrdered.TabIndex = 12;
            this.txtOrdered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount Ordered";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount Reeived";
            // 
            // frmReceiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrdered);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdDataReceive);
            this.Controls.Add(this.grdDataOrder);
            this.Controls.Add(this.grdDataSuppliers);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReceiveOrder";
            this.Text = "Receive Order";
            this.Load += new System.EventHandler(this.frmReceiveOrder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.DataGridView grdDataSuppliers;
        private System.Windows.Forms.DataGridView grdDataOrder;
        private System.Windows.Forms.DataGridView grdDataReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtReceived;
        private System.Windows.Forms.TextBox txtOrdered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
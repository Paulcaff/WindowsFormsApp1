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
            this.lstBoxReceiveOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnReceived = new System.Windows.Forms.Button();
            this.btnNotReceived = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
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
            // lstBoxReceiveOrder
            // 
            this.lstBoxReceiveOrder.FormattingEnabled = true;
            this.lstBoxReceiveOrder.HorizontalScrollbar = true;
            this.lstBoxReceiveOrder.Items.AddRange(new object[] {
            "Quantity\t\tProduct",
            "",
            "12 \t \tGuinness",
            "4  \t\tCarlsberg",
            "24 \t \tPint Btls Bulmers",
            "6\t \tBudweiser",
            "2 \t \tHop house",
            "2 \t \tRock Shore "});
            this.lstBoxReceiveOrder.Location = new System.Drawing.Point(53, 42);
            this.lstBoxReceiveOrder.Name = "lstBoxReceiveOrder";
            this.lstBoxReceiveOrder.ScrollAlwaysVisible = true;
            this.lstBoxReceiveOrder.Size = new System.Drawing.Size(383, 134);
            this.lstBoxReceiveOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Supplier ";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(244, 287);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(169, 20);
            this.txtSupplier.TabIndex = 3;
            // 
            // btnReceived
            // 
            this.btnReceived.Location = new System.Drawing.Point(107, 202);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(62, 23);
            this.btnReceived.TabIndex = 4;
            this.btnReceived.Text = "Received";
            this.btnReceived.UseVisualStyleBackColor = true;
            // 
            // btnNotReceived
            // 
            this.btnNotReceived.Location = new System.Drawing.Point(267, 202);
            this.btnNotReceived.Name = "btnNotReceived";
            this.btnNotReceived.Size = new System.Drawing.Size(83, 23);
            this.btnNotReceived.TabIndex = 5;
            this.btnNotReceived.Text = "Not Received";
            this.btnNotReceived.UseVisualStyleBackColor = true;
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Location = new System.Drawing.Point(119, 360);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(194, 38);
            this.btnReceiveOrder.TabIndex = 6;
            this.btnReceiveOrder.Text = "Update Files";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            // 
            // frmReceiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.btnNotReceived);
            this.Controls.Add(this.btnReceived);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxReceiveOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReceiveOrder";
            this.Text = "Receive Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ListBox lstBoxReceiveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnReceived;
        private System.Windows.Forms.Button btnNotReceived;
        private System.Windows.Forms.Button btnReceiveOrder;
    }
}
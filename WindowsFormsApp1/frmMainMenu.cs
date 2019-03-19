using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMainMenu : Form
    {
       

        public frmMainMenu()
        {
            InitializeComponent();
        }

      


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAddStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStock nextform = new frmAddStock(this);
            nextform.Show();
        }

        private void mnuUpdateStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateStock nextform = new frmUpdateStock(this);
            nextform.Show();
        }

        private void mnuRemoveStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveStock nextform = new frmRemoveStock(this);
            nextform.Show();
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {

        }

        private void mnuPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceOrder nextform = new frmPlaceOrder(this);
            nextform.Show();
        }

        private void mnuReceiveOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReceiveOrder nextform = new frmReceiveOrder(this);
            nextform.Show();

        }

       
        private void mnuReturnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnStock nextform = new frmReturnStock(this);
            nextform.Show();
        }

        private void mnuAddSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSupplier nextform = new frmAddSupplier(this);
            nextform.Show();
        }

        private void mnuUpdateSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateSupplier nextform = new frmUpdateSupplier(this);
            nextform.Show();
        }

        private void mnuCloseSupplierAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseSupplierAccount nextform = new frmCloseSupplierAccount(this);
            nextform.Show();
        }

        private void mnuPaySuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaySupplier nextform = new frmPaySupplier(this);
            nextform.Show();
        }

        private void mnuShowBestSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis nextform = new frmYearlyRevenueAnalysis(this);
            nextform.Show();
        }

        private void mnuShowWorstSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowStockPerformance nextform = new frmShowStockPerformance(this);
            nextform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mnuCancelOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelOrder nextform = new frmCancelOrder(this);
            nextform.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order.getOrderStatus(11);
        }
    }
}

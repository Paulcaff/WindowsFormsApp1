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
    public partial class frmAddStock : Form
    {

        frmMainMenu parent;
        public frmAddStock()
        {
            InitializeComponent();
        }

        public frmAddStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent =  Parent;
        }



        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int StockId = Convert.ToInt16(Stock.getNextStockId());
            string name = txtStockName.Text;
            string description = txtDescription.Text;
            int amount = Convert.ToInt16(txtAmount.Text);
            float quantity =float.Parse(txtPrice.Text);
            int supplier = Convert.ToInt16(txtSupplier.Text);
            string status = "A";
            //git working?

            Stock newStock = new Stock(StockId, name,description, amount, quantity, supplier, status);
            newStock.AddStock();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            txtStockId.Text = Stock.getNextStockId().ToString("00000");
            txtStockName.Focus();
        }

        private void txtStockName_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateAdd(txtStockName.Text);

            if (valid == false)
            {
                txtStockName.Focus();
                MessageBox.Show("Incorrect Name");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateAdd(txtDescription.Text);

            if (valid == false)
            {
                txtDescription.Focus();
                MessageBox.Show("Invalid characters used during description");
            }
        }

        private void txtSupplier_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateId(txtSupplier.Text);

            if(valid == false)
            {
                txtSupplier.Focus();
            }
        }
    }
}

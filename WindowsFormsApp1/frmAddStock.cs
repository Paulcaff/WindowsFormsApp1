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

       

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Boolean valid = Validation.ValidateAdd(txtStockName.Text);

            if (valid == false)
            {
                txtStockName.Focus();
                MessageBox.Show("Incorrect Name");
            }

            Boolean validDesc = Validation.ValidateAdd(txtDescription.Text);

            if (validDesc == false)
            {
                txtDescription.Focus();
                MessageBox.Show("Invalid characters used during description");
            }

            Boolean validSupplier = Validation.ValidateId(txtSupplier.Text);

            if (validSupplier == false)
            {
                txtSupplier.Focus();
            }

            if (valid && validDesc && validSupplier)
            { 

            int StockId = Convert.ToInt16(Stock.getNextStockId());
            string name = txtStockName.Text;
            string description = txtDescription.Text;
            int amount = Convert.ToInt16(txtAmount.Text);
            float quantity = float.Parse(txtPrice.Text);
            int supplier = Convert.ToInt16(txtSupplier.Text);
            string status = "A";
                //git working?
                MessageBox.Show("Here");

            Stock newStock = new Stock(StockId, name, description, amount, quantity, supplier, status);
            newStock.AddStock();

                MessageBox.Show("You have added a new item of Stock");

                txtStockId.Clear();
                txtStockName.Clear();
                txtDescription.Clear();
                txtSupplier.Clear();
                txtAmount.Value = 0;
                txtPrice.Value = 0;

                txtStockId.Text = Stock.getNextStockId().ToString("00000");
                txtStockName.Focus();


            }
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            txtStockId.Text = Stock.getNextStockId().ToString("00000");
            txtStockName.Focus();
        }

       

      

      
    }
}

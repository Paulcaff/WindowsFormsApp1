using Oracle.ManagedDataAccess.Client;
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
    public partial class frmUpdateStock : Form
    {
        frmMainMenu parent;
        public frmUpdateStock()
        {
            InitializeComponent();
        }

        public frmUpdateStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {
            grpStock.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Stock.getUpdateStock(ds, txtSearch.Text).Tables["stk"];
        }

        private void grdData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtStockId.Text = grdData.SelectedRows[0].Cells[0].Value.ToString();
            txtStockName.Text = grdData.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = grdData.SelectedRows[0].Cells[2].Value.ToString();
            txtAmount.Text = grdData.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = grdData.SelectedRows[0].Cells[4].Value.ToString();
            txtSupplier.Text = grdData.SelectedRows[0].Cells[5].Value.ToString();
            txtStatus.Text = grdData.SelectedRows[0].Cells[6].Value.ToString();

            grpStock.Show();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
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

            Boolean validStatus = Validation.ValidateStatus(txtStatus.Text);

            if (validStatus == false)
            {
                txtStatus.Focus();
                MessageBox.Show("Status has to be 1 character long");
            }

            if (valid && validDesc && validSupplier && validStatus)
            {



                int StockId = Convert.ToInt16(txtStockId.Text);
                string name = txtStockName.Text;
                string description = txtDescription.Text;
                int amount = Convert.ToInt16(txtAmount.Text);
                float price = float.Parse(txtPrice.Text);
                int supplier = Convert.ToInt16(txtSupplier.Text);
                string status = txtStatus.Text;

                MessageBox.Show(""+StockId+name+description+amount+price+supplier+status);


                //connect to the db
                OracleConnection connect = new OracleConnection(DBConnect.oradb);

                //define Sql Command
                String strSQL = "UPDATE Stock SET StockName = '" + name + "',Description = '" + description + "',Amount = " + amount + ", Price = " + price + ", SupplierId = " + supplier + ", Status = '" + status + "' where StockId = " + StockId;
                MessageBox.Show("Here");

                //Execute Query
                OracleCommand cmd = new OracleCommand(strSQL, connect);

              

                connect.Open();
                

                cmd.ExecuteNonQuery();

           


                //Close Db
                connect.Close();
                

                txtSearch.Clear();
                txtStockId.Clear();
                txtStockName.Clear();
                txtDescription.Clear();
                txtAmount.Clear();
                txtPrice.Clear();
                txtSupplier.Clear();
                txtStatus.Clear();
                
            }
        }
    }
}

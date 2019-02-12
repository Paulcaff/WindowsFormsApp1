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
            DataSet ds = new DataSet();

            grdData.DataSource = Stock.getAvailableStock(ds, txtSearch.Text).Tables["stk"];

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

            grdData.DataSource = Stock.getAvailableStock(ds, txtSearch.Text.ToUpper()).Tables["stk"];
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

            

            if (valid && validDesc && validSupplier )
            {



                int StockId = Convert.ToInt16(txtStockId.Text);
                string name = txtStockName.Text;
                string description = txtDescription.Text;
                int amount = Convert.ToInt16(txtAmount.Text);
                float price = float.Parse(txtPrice.Text);
                int supplier = Convert.ToInt16(txtSupplier.Text);
                

                MessageBox.Show(""+StockId+name+description+amount+price+supplier);


                //connect to the db
                OracleConnection connect = new OracleConnection(DBConnect.oradb);

                //define Sql Command
                String strSQL = "UPDATE Stock SET StockName = '" + name + "',Description = '" + description + "',Amount = " + amount + ", Price = " + price + ", SupplierId = " + supplier + ", Status = 'A' where StockId = " + StockId;
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
                
                
            }
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtStockId.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtStockName.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtAmount.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtSupplier.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[5].Value.ToString();
            

            grpStock.Show();

        }
    }
}

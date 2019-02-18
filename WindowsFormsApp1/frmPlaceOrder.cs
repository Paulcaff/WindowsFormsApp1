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
    public partial class frmPlaceOrder : Form
    {
        frmMainMenu parent;
        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        public frmPlaceOrder(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            
            label6.Text = Order.getNextOrderId().ToString("00000");
            grpStockSelection.Hide();
            DataSet ds = new DataSet();
            grdDataSupp.DataSource = Supplier.getAllSuppliers(ds).Tables["stk"];
        }

        private void grdDataSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdForSearch.Text = grdDataSupp.Rows[grdDataSupp.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(txtIdForSearch.Text);

            txtBalance.Text = "0.0";
      

            grpStockSelection.Show();
            DataSet ds = new DataSet();
            grdDataStock.DataSource = Stock.getStocktoBuy(ds, id).Tables["stk"];
            
        }

        private void grdDataStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //label8.Text = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //float price = float.Parse(label8.Text);
            label7.Text = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[0].Value.ToString();

            txtPrice.Text = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[4].Value.ToString();
            float price = float.Parse(txtPrice.Text);

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
           
                Boolean valid = Validation.ValidateAmount(txtAmountOrder.Text);

                if (valid == false)
                {
                txtAmountOrder.Focus();
                    MessageBox.Show("Incorrect Amount entered");
                }

               

                if (valid)
                {
                //Fix Here
                int OrderId = 1;//Convert.ToInt16(label6.Text);
                int StockId = Convert.ToInt16(label7.Text);
                float Price = float.Parse(txtPrice.Text);
                int Quantity = Convert.ToInt16(txtAmountOrder.Text);
                
                    MessageBox.Show("" + OrderId + StockId + Price + Quantity);


                    //connect to the db
                    OracleConnection connect = new OracleConnection(DBConnect.oradb);

                    //define Sql Command
                    String strSQL = "INSERT INTO OrderItems VALUES("+OrderId+","+StockId +","+ Price +","+ Quantity+")" ;
                    MessageBox.Show("Here");

                    //Execute Query
                    OracleCommand cmd = new OracleCommand(strSQL, connect);



                    connect.Open();

                cmd.ExecuteNonQuery();




                    //Close Db
                    connect.Close();


                    txtAmountOrder.Clear();
                   


                }
            }
        }
    }


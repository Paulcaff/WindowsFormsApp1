using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            label8.Text = grdDataSupp.Rows[grdDataSupp.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label8.Text);

            txtBalance.Text = "0.0";
      

            grpStockSelection.Show();
            DataSet ds = new DataSet();
            grdDataStock.DataSource = Stock.getStocktoBuy(ds, id).Tables["stk"];
            
        }

        private void grdDataStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                
                int OrderId = Convert.ToInt16(label6.Text);
                int StockId = Convert.ToInt16(label7.Text);
                float Price = float.Parse(txtPrice.Text);
                int Quantity = Convert.ToInt16(txtAmountOrder.Text);
                int SupplierId = Convert.ToInt16(label8.Text);
                string Status = "A";
                float total = float.Parse(txtBalance.Text);

                DateTime dt = DateTime.Now;
                string date = dt.ToString("dd-MMM-yyyy");

                MessageBox.Show("" + date);






                using (OracleConnection connection = new OracleConnection(DBConnect.oradb))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction();

                    // Must assign both transaction object and connection
                    // to Command object for a pending local transaction
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        //microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.begintransaction?view=netframework-4.7.2
                        MessageBox.Show("Here");

                        command.CommandText =
                            "Insert into Orders VALUES (" + OrderId + ",'" + date + "'," + SupplierId + "," + total + ",'" + Status + "')";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Here");

                        command.CommandText =
                             "INSERT INTO OrderItems VALUES(" + OrderId + "," + StockId + "," + Price + "," + Quantity + ")";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Here");

                        // Attempt to commit the transaction.
                        transaction.Commit();
                        Console.WriteLine("Both records are written to database.");
                    }
                    
                    catch (Exception ex)
                    {
                        Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                        Console.WriteLine("  Message: {0}", ex.Message);

                        // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                            Console.WriteLine("  Message: {0}", ex2.Message);
                        }
                    }
                }


                /* //connect to the db
                 OracleConnection connect = new OracleConnection(DBConnect.oradb);

                 //define Sql Command
                 String strSQL = "INSERT INTO OrderItems VALUES("+OrderId+","+StockId +","+ Price +","+ Quantity+")" ;
                 MessageBox.Show("Here");

                 //Execute Query
                 OracleCommand cmd = new OracleCommand(strSQL, connect);



                 connect.Open();

             cmd.ExecuteNonQuery();




                 //Close Db
                 connect.Close();*/


                txtAmountOrder.Clear();
                   


                }
            }
        }
    }


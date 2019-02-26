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
            grpStockSelection.Hide();
            grpAddCart.Hide();
            btnRemove.Hide();
            grpCart.Hide();

            DataSet ds = new DataSet();
            grdDataSupp.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];

            grdDataCart.Columns.Add("OrderID", "OrderId");
            grdDataCart.Columns.Add("StockID", "StockId");
            grdDataCart.Columns.Add("StockName", "StockName");
            grdDataCart.Columns.Add("Price", "Price");
            grdDataCart.Columns.Add("Quantity", "Quantity");
            grdDataCart.Columns.Add("Total for Product", "Total For Product");
        }

        private void grdDataSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = grdDataSupp.Rows[grdDataSupp.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label8.Text);

            txtBalance.Text = "0.00";


            grpStockSelection.Show();
            DataSet ds = new DataSet();
            grdDataStock.DataSource = Stock.getStocktoBuy(ds, id).Tables["stk"];

        }

        private void grdDataStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpAddCart.Show();
            grpSupplier.Hide();
            grpCart.Show();
            grdDataCart.Show();
            label7.Text = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[0].Value.ToString();

            txtPrice.Text = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[4].Value.ToString();
            float price = float.Parse(txtPrice.Text);

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            grpCart.Show();
            grdDataCart.Show();

            if (txtAmountOrder.Value > 0)
            {
                Boolean inserted = false;


                int StockId = Convert.ToInt16(label7.Text);
                int quantity = Convert.ToInt16(txtAmountOrder.Text);
                int OrderId = Order.getNextOrderId();
                string StockName = grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[1].Value.ToString();
                float price = float.Parse(grdDataStock.Rows[grdDataStock.CurrentCell.RowIndex].Cells[4].Value.ToString());
                float total = price * quantity;


                for (int i = 0; i < grdDataCart.RowCount; i++)
                {

                    int present = Convert.ToInt16(grdDataCart.Rows[i].Cells[1].Value.ToString());

                    if (StockId == present)
                    {
                        grdDataCart.Rows[i].Cells[4].Value = Convert.ToInt16(grdDataCart.Rows[i].Cells[4].Value) + quantity;
                        grdDataCart.Rows[i].Cells[5].Value = Convert.ToInt16(grdDataCart.Rows[i].Cells[5].Value) + (price * quantity);
                        float balance = float.Parse(txtBalance.Text) + (price * quantity);
                        txtBalance.Text = balance.ToString();


                        inserted = true;
                        MessageBox.Show("Item Updated");
                    }



                }

                if (!inserted)
                {
                    this.grdDataCart.Rows.Add(OrderId, StockId, StockName, price, quantity, total);

                    float balance = float.Parse(txtBalance.Text) + (price * quantity);
                    txtBalance.Text = balance.ToString();
                    MessageBox.Show("Item Ordered");
                }
            }

            else
            {
                MessageBox.Show("Not enough in stock to order or nothing been ordered");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            float deduction = float.Parse(grdDataCart.Rows[grdDataCart.CurrentCell.RowIndex].Cells[4].Value.ToString());
            float productTotal = float.Parse(grdDataCart.Rows[grdDataCart.CurrentCell.RowIndex].Cells[5].Value.ToString());
            MessageBox.Show("DEDUCT" + deduction);
            grdDataCart.Rows.Remove(grdDataCart.CurrentRow);

            float balance = float.Parse(txtBalance.Text) - (productTotal);
            txtBalance.Text = balance.ToString();

        }


        private void grdDataCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (grdDataCart.RowCount == 0)
            {
                MessageBox.Show("There is nothing in the shopping Cart");
            }
            else
            {
                int OrderId = Order.getNextOrderId();
                int SupplierId = Convert.ToInt16(label8.Text);
                string Status = "O";
                float total = float.Parse(txtBalance.Text);
                //float OriginalBalance = float.Parse(grdDataSupp.Rows[grdDataStock.CurrentCell.RowIndex].Cells[2].Value);

                DateTime dt = DateTime.Now;
                string date = dt.ToString("dd-MMM-yyyy");

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


                        command.CommandText =
                            "Insert into Orders VALUES (" + OrderId + ",'" + date + "'," + SupplierId + "," + total + ",'" + Status + "')";
                        command.ExecuteNonQuery();


                        float currentBalance = float.Parse(grdDataSupp.Rows[grdDataSupp.CurrentCell.RowIndex].Cells[2].Value.ToString());
                        float newBalance = currentBalance + total;




                        for (int i = 0; i < grdDataCart.RowCount; i++)
                        {


                            int StockId = Convert.ToInt16(grdDataCart.Rows[i].Cells[1].Value.ToString());
                            float price = float.Parse(grdDataCart.Rows[i].Cells[3].Value.ToString());
                            int quantity = Convert.ToInt16(grdDataCart.Rows[i].Cells[4].Value.ToString());


                            MessageBox.Show("" + OrderId + " " + StockId + " " + price + " " + quantity);



                            command.CommandText =
                             "INSERT INTO OrderItems VALUES(" + OrderId + "," + StockId + "," + price + "," + quantity + ",'O')";
                            command.ExecuteNonQuery();


                        }

                        command.CommandText =
                            "UPDATE Supplier SET Balance = " + newBalance + "where SupplierId = " + SupplierId;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Commit next");

                        // Attempt to commit the transaction.
                        transaction.Commit();

                        txtAmountOrder.Value = 0;
                        grdDataCart.Rows.Clear();
                        grdDataCart.Hide();

                        txtPrice.Clear();
                        txtBalance.Clear();
                        grpCart.Hide();
                        grpAddCart.Hide();
                        grpStockSelection.Hide();

                        DataSet ds = new DataSet();
                        grdDataSupp.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];

                        grpSupplier.Show();




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
            }
            
        }

        
    }
}


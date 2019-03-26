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
    public partial class frmReceiveOrder : Form
    {
        frmMainMenu parent;
        public frmReceiveOrder()
        {
            InitializeComponent();
        }

        public frmReceiveOrder(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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

        private void frmReceiveOrder_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();

            DataSet ds = new DataSet();
            grdDataSuppliers.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];
            grdDataSuppliers.Columns[0].Visible = false;

        }

        private void grdDataSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = grdDataSuppliers.Rows[grdDataSuppliers.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label1.Text);

            DataSet ds = new DataSet();
            grdDataOrder.DataSource = Order.getOrders(ds, id).Tables["stk"];
            grdDataOrder.Columns[0].Visible = false;
            grdDataOrder.Columns[2].Visible = false;
        }

        private void grdDataOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            label2.Text = grdDataOrder.Rows[grdDataOrder.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label2.Text);

            DataSet ds = new DataSet();
           
            grdDataReceive.DataSource = OrderItems.getOrderItems(ds, id).Tables["stk"];
            grdDataReceive.Columns[0].Visible = false;

        }

        private void grdDataReceive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrdered.Text = grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[2].Value.ToString();
            int value = Convert.ToInt16(grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[2].Value.ToString()) - Convert.ToInt16(grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[4].Value.ToString());
            txtReceived.Text = value.ToString();
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {

            if (grdDataReceive.RowCount == 0)
            {
                MessageBox.Show("There is nothing received to update");
            }
            else
            {

                int orderId = Convert.ToInt16(label2.Text);


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
                                               
                        
                            int amount = Convert.ToInt16(grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[2].Value.ToString());
                            int id = Convert.ToInt16(grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[0].Value.ToString());
                            int receivedNow = Convert.ToInt16(txtReceived.Text);
                            int orderid = Convert.ToInt16(grdDataOrder.Rows[grdDataOrder.CurrentCell.RowIndex].Cells[0].Value.ToString());
                            int alreadyReceived = Convert.ToInt16(grdDataReceive.Rows[grdDataReceive.CurrentCell.RowIndex].Cells[4].Value.ToString());

                        if ((receivedNow + alreadyReceived) <= amount)
                        {

                            if (amount == receivedNow + alreadyReceived)
                            {
                                command.CommandText =
                                 "UPDATE STOCK SET AMOUNT = (AMOUNT +" + amount + ") WHERE STOCKID = " + id;
                                command.ExecuteNonQuery();

                                command.CommandText =
                                 "UPDATE OrderItems SET ReceivedStock = (ReceivedStock +" + receivedNow + "),STATUS = 'R' where StockId = " + id;
                                command.ExecuteNonQuery();

                                grdDataReceive.Rows.RemoveAt(grdDataReceive.CurrentRow.Index);
                            }
                            else
                            {
                                command.CommandText =
                                 "UPDATE STOCK SET AMOUNT = (AMOUNT +" + amount + ") WHERE STOCKID = " + id;
                                command.ExecuteNonQuery();

                                command.CommandText =
                                 "UPDATE OrderItems SET ReceivedStock = (ReceivedStock +" + receivedNow + ") where StockId = " + id;
                                command.ExecuteNonQuery();

                                grdDataReceive.Rows.RemoveAt(grdDataReceive.CurrentRow.Index);
                            }



                            transaction.Commit();

                            Order.getOrderStatus(orderid);

                            DataSet ds = new DataSet();
                            grdDataSuppliers.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];

                            

                            

                        }

                        else
                        {
                            MessageBox.Show("you cant receive more stock than you ordered");
                        }

                        




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

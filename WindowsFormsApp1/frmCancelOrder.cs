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
    public partial class frmCancelOrder : Form
    {
        frmMainMenu parent;
        public frmCancelOrder()
        {
            InitializeComponent();
        }

        public frmCancelOrder(frmMainMenu Parent)
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

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Supplier.getSupplierOrders(ds, txtSupplierName.Text).Tables["stk"];
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int id = Convert.ToInt16(grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value.ToString());
                 
            DataSet ds = new DataSet();
            grdDataOrders.DataSource = Order.getOrdersWithSupplierName(ds, id).Tables["stk"];
        }

        private void grdDataOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id = Convert.ToInt16(grdDataOrders.Rows[grdDataOrders.CurrentCell.RowIndex].Cells[3].Value.ToString());

            DataSet ds = new DataSet();

            grdDataItems.DataSource = OrderItems.getCancelItems(ds, id).Tables["stk"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Boolean delete = true;
            int id = Convert.ToInt16(grdDataOrders.Rows[grdDataOrders.CurrentCell.RowIndex].Cells[3].Value.ToString());
            float refund = float.Parse(grdDataOrders.Rows[grdDataOrders.CurrentCell.RowIndex].Cells[2].Value.ToString());
            int suppid = Convert.ToInt16(grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value.ToString());
            float balance = float.Parse(grdData.Rows[grdData.CurrentCell.RowIndex].Cells[2].Value.ToString());
            float newBalance = balance - refund;



            for (int i = 0; i < grdDataItems.RowCount; i++)
            {
                if (grdDataItems.Rows[i].Cells[3].Value.Equals("O"))
                {
                    MessageBox.Show("" + delete);

                }
                else
                {
                    delete = false;
                    MessageBox.Show("" + delete);
                    break;
                }

            }

            MessageBox.Show("AFTER LOOP" + delete);

            if (delete)
            {
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
                           "UPDATE SUPPLIER SET BALANCE ="+newBalance+" where SUPPLIERID = "+suppid;
                        command.ExecuteNonQuery();

                        command.CommandText =
                            "DELETE FROM ORDERITEMS WHERE ORDERID = "+id;
                        command.ExecuteNonQuery();

                        command.CommandText =
                            "DELETE FROM ORDERS WHERE ORDERID = " + id;
                        command.ExecuteNonQuery();




                        MessageBox.Show("Commit next");

                        // Attempt to commit the transaction.
                        transaction.Commit();

                        

                        DataSet ds = new DataSet();
                        grdData.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];

                        




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
            else
            {
                MessageBox.Show("This cannot be deleted as order has been partially received");
            }

            txtSupplierName.Clear();
            grdData.DataSource = null;
            grdDataOrders.DataSource = null;
            grdDataItems.DataSource = null;
        }
    }
}

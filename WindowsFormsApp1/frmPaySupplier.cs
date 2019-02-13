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
    public partial class frmPaySupplier : Form
    {
        frmMainMenu parent;
        public frmPaySupplier()
        {
            InitializeComponent();
        }

        public frmPaySupplier(frmMainMenu Parent)
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

        private void frmPaySupplier_Load(object sender, EventArgs e)
        {
            grpPaySupplier.Hide();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierId.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSupplierName.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtBalance.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[9].Value.ToString();

            grpPaySupplier.Show();

        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Supplier.getAvailableSupplier(ds, txtSearchSupplier.Text).Tables["stk"];
        }

        private void btnPaySupplier_Click(object sender, EventArgs e)
        {
            Boolean valid = Validation.ValidateAmount(txtAmountToPay.Text);

            if (valid)
            {

                float pay = float.Parse(txtAmountToPay.Text);
                float balance = float.Parse(txtBalance.Text);

                if (balance > 0)
                {
                    if (balance > pay)
                    {
                        float remainder = balance - pay;
                        int id = Convert.ToInt16(txtSupplierId.Text);

                        //connect to the db
                        OracleConnection connect = new OracleConnection(DBConnect.oradb);

                        //define Sql Command
                        String strSQL = "UPDATE Supplier SET Balance = " + remainder + " WHERE SupplierId =" + id;

                        //Execute Query
                        OracleCommand cmd = new OracleCommand(strSQL, connect);

                        connect.Open();

                        cmd.ExecuteNonQuery();

                        //Close Db
                        connect.Close();


                        txtSupplierId.Clear();
                        txtSupplierName.Clear();
                        txtSearchSupplier.Clear();
                        txtBalance.Clear();
                        txtAmountToPay.Clear();
                        
                        grdData.DataSource = null;
                        



                    }
                    else
                    {
                        MessageBox.Show("The amount you want to pay exceeds the balance");
                    }

                }
                else
                {
                    MessageBox.Show("The balance is zero so Cannot be paid");
                }
            }

            else
            {
                MessageBox.Show("You have not entered a correct amount into the Amount to Pay Textbox");
            }
        }

       
    }
}

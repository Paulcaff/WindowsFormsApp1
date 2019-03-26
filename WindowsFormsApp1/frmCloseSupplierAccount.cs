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
    public partial class frmCloseSupplierAccount : Form
    {
        frmMainMenu parent;
        public frmCloseSupplierAccount()
        {
            InitializeComponent();
        }

        public frmCloseSupplierAccount(frmMainMenu Parent)
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

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierId.Text = grdData.SelectedRows[0].Cells[0].Value.ToString();
            txtSupplierName.Text = grdData.SelectedRows[0].Cells[1].Value.ToString();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Supplier.getAvailableSupplier(ds, txtSearch.Text).Tables["stk"];
        }

        private void btnCloseSupplierAccount_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtSupplierId.Text);
            string name = txtSupplierName.Text;
            float balance = float.Parse(grdData.SelectedRows[0].Cells[9].Value.ToString());
            

            if (balance == 0)
            {

                //connect to the db
                OracleConnection connect = new OracleConnection(DBConnect.oradb);

                //define Sql Command
                String strSQL = "UPDATE Supplier SET Status = 'D' WHERE SupplierId =" + id;

                //Execute Query
                OracleCommand cmd = new OracleCommand(strSQL, connect);

                connect.Open();

                cmd.ExecuteNonQuery();

                //Close Db
                connect.Close();

                MessageBox.Show(name + " has been deleted");

                txtSearch.Clear();
                txtSupplierId.Clear();
                txtSupplierName.Clear();

            }
            else
            {
                MessageBox.Show("the balance has to be 0 to delete a supplier");
            }
        }
    }
}

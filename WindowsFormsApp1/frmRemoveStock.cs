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
    public partial class frmRemoveStock : Form
    {
        frmMainMenu parent;
        public frmRemoveStock()
        {
            InitializeComponent();
        }

        public frmRemoveStock(frmMainMenu Parent)
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

     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Stock.getAvailableStock(ds, txtSearch.Text.ToUpper()).Tables["stk"];
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStockId.Text = grdData.SelectedRows[0].Cells[0].Value.ToString();
            txtStockName.Text = grdData.SelectedRows[0].Cells[1].Value.ToString().ToUpper();
        }



        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtStockId.Text);
            string name = txtStockName.Text;
            
            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "UPDATE Stock SET Status = 'D' WHERE StockId ="+id;

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            //Close Db
            connect.Close();

            MessageBox.Show(name + " has been deleted");

            txtSearch.Clear();
            txtStockId.Clear();
            txtStockName.Clear();
            grdData.DataSource = null;
        }

        
    }
}

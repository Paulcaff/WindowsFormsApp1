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
            DataSet ds = new DataSet();
            grdDataSuppliers.DataSource = Supplier.getSupplierSummary(ds).Tables["stk"];

           // grdDataReceive.Columns.Add("StockID", "StockId");
           // grdDataReceive.Columns.Add("StockName", "Stock Name");
            //grdDataReceive.Columns.Add("Amount", "Amount");

        }

        private void grdDataSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = grdDataSuppliers.Rows[grdDataSuppliers.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label1.Text);

            DataSet ds = new DataSet();
            grdDataOrder.DataSource = Order.getOrders(ds, id).Tables["stk"];
        }

        private void grdDataOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

             label2.Text = grdDataOrder.Rows[grdDataOrder.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int id = Convert.ToInt16(label2.Text);

            DataSet ds = new DataSet();
            MessageBox.Show("" + ds);
            grdDataReceive.DataSource = OrderItems.getOrderItems(ds, id).Tables["stk"];

        }
    }
}

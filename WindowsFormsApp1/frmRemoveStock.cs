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

        private void RemoveStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoveStock_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Stock.getUpdateStock(ds, txtSearch.Text).Tables["stk"];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Stock.getUpdateStock(ds, txtSearch.Text).Tables["stk"];
        }
    }
}

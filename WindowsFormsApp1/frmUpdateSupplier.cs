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
    public partial class frmUpdateSupplier : Form
    {
        frmMainMenu parent;
        public frmUpdateSupplier()
        {
            InitializeComponent();
           
        }

        public frmUpdateSupplier(frmMainMenu Parent)
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

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            grpSupplier.Hide();   
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Supplier.getAvailableSupplier(ds,txtSearch.Text).Tables["stk"];

            


        }


        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {

            Boolean validName = Validation.ValidateName(txtSupplierName.Text);

            if (validName == false)
            {
                txtSupplierName.Clear();
                txtSupplierName.Focus();
                MessageBox.Show("Incorrect Name format");
            }

            Boolean validAdd1 = Validation.ValidateAdd(txtAddressLine1.Text);

            if (validAdd1 == false)
            {
                txtAddressLine1.Clear();
                txtAddressLine1.Focus();
                MessageBox.Show("Incorrect Address Line 1");
            }

            Boolean validAdd2 = Validation.ValidateAdd(txtAddressLine2.Text);

            if (validAdd2 == false)
            {
                txtAddressLine2.Clear();
                txtAddressLine2.Focus();
                MessageBox.Show("Incorrect Address Line 2");
            }

            Boolean validTown = Validation.ValidateTown(txtTown.Text);

            if (validTown == false)
            {
                txtTown.Focus();
                MessageBox.Show("Incorrect Town");
            }

            Boolean validCounty = Validation.ValidateCounty(txtCounty.Text);

            if (validCounty == false)
            {
                txtCounty.Focus();
                MessageBox.Show("Incorrect County");
            }

            Boolean validPhone = Validation.ValidatePhone(txtPhone.Text);

            if (validPhone == false)
            {
                txtPhone.Clear();
                txtPhone.Focus();
                MessageBox.Show("Incorrect Phone format");
            }

            Boolean validEmail = Validation.ValidateEmail(txtEmail.Text);

            if (validEmail == false)
            {
                txtEmail.Focus();
                MessageBox.Show("Incorrect Email address");
            }

            if (validName && validAdd1 && validAdd2 && validTown && validCounty && validPhone && validEmail)
            {


                int supplierId = Convert.ToInt16(txtSupplierId.Text);
                string name = txtSupplierName.Text;
                string add1 = txtAddressLine1.Text;
                string add2 = txtAddressLine2.Text;
                string town = txtTown.Text;
                string county = txtCounty.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                



                MessageBox.Show("" + supplierId + name + add1 + add2 + town + county + email + phone );

                //connect to the db
                OracleConnection connect = new OracleConnection(DBConnect.oradb);

                //define Sql Command
                String strSQL = "UPDATE Supplier SET SupplierName = '" + name + "',AddressLine1 = '" + add1 + "',AddressLine2 = '" + add2 + "', Town = '" + town + "', County = +'" + county + "', Email = '" + email + "', Phone = '" + phone + "', Status = 'A' where SupplierId = " + supplierId;

                //Execute Query
                OracleCommand cmd = new OracleCommand(strSQL, connect);

                connect.Open();

                cmd.ExecuteNonQuery();

             
                //Close Db
                connect.Close();

                txtSearch.Clear();
                txtSupplierId.Clear();
                txtSupplierName.Clear();
                txtAddressLine1.Clear();
                txtAddressLine2.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                
                
                txtSearch.Focus();

                grdData.DataSource = null;
            }

        }

  

        private void frmUpdateSupplier_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSupplierId.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSupplierName.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtAddressLine1.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtAddressLine2.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtTown.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtCounty.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtPhone.Text = grdData.Rows[grdData.CurrentCell.RowIndex].Cells[7].Value.ToString();
           

            grpSupplier.Show();
        }
    }
}


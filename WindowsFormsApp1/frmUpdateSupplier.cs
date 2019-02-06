﻿using Oracle.ManagedDataAccess.Client;
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
            /* string name = txtSupplierName.Text;
             string add1 = txtAddressLine1.Text;
             string add2 = txtAddressLine2.Text;
             string town = txtTown.Text;
             string county = txtCounty.Text;
             string email = txtEmail.Text;
             string phone = txtPhone.Text;*/

            txtSearch.Focus();

            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdData.DataSource = Supplier.getUpdateSupplier(ds,txtSearch.Text).Tables["stk"];


        }

        private void grdData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtSupplierId.Text = grdData.SelectedRows[0].Cells[0].Value.ToString();
            txtSupplierName.Text = grdData.SelectedRows[0].Cells[1].Value.ToString();
            txtAddressLine1.Text = grdData.SelectedRows[0].Cells[2].Value.ToString();
            txtAddressLine2.Text = grdData.SelectedRows[0].Cells[3].Value.ToString();
            txtTown.Text= grdData.SelectedRows[0].Cells[4].Value.ToString();
            txtCounty.Text = grdData.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = grdData.SelectedRows[0].Cells[6].Value.ToString();
            txtPhone.Text = grdData.SelectedRows[0].Cells[7].Value.ToString();
            txtStatus.Text = grdData.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            string supplierId = txtSupplierId.Text;
            string name = txtSupplierName.Text;
            string add1 = txtAddressLine1.Text;
            string add2 = txtAddressLine2.Text;
            string town = txtTown.Text;
            string county = txtCounty.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string status = txtStatus.Text;

            MessageBox.Show("" + supplierId + name + add1 + add2 + town + county + email + phone + status);

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "UPDATE Supplier SET SupplierName = name,AddressLine1 = add1,AddressLine2 = add2, Town = town, County = county, Email = email, Phone = phone, Status = status where supplierId = SupplierId";

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();





            //Close Db
            connect.Close();


        }
    }
}


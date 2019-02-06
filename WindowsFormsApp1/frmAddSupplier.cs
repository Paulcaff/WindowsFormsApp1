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
    public partial class frmAddSupplier : Form
    {
        frmMainMenu parent;
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        public frmAddSupplier(frmMainMenu Parent)
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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt16(Supplier.getNextSupplierId());
            string name = txtSupplierName.Text;
            string add1 = txtAddressLine1.Text;
            string add2 = txtAddressLine2.Text;
            string town = txtTown.Text;
            string county = txtCounty.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string status = "A";

            MessageBox.Show(""+supplierId+name+add1+add2+town+county+email+phone+status);

            Supplier newSupplier = new Supplier(supplierId, name, add1, add2, town, county, email, phone,status);
            newSupplier.AddSupplier();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierId.Text =Supplier.getNextSupplierId().ToString("00000");
            txtSupplierName.Focus();
        }

     

        private void txtSupplierName_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateName(txtSupplierName.Text);

            if (valid == false)
            {
                txtSupplierName.Clear();
                txtSupplierName.Focus();
                MessageBox.Show("Incorrect Name format");
            }
        }

        private void txtAddressLine1_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateAdd(txtAddressLine1.Text);

            if(valid == false)
            {
                txtAddressLine1.Clear();
                txtAddressLine1.Focus();
                MessageBox.Show("Incorrect Address Line 1");
            }
        }

        private void txtAddressLine2_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateAdd(txtAddressLine2.Text);

            if (valid == false)
            {
                txtAddressLine2.Clear();
                txtAddressLine2.Focus();
                MessageBox.Show("Incorrect Address Line 2");
            }
        }

        private void txtTown_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateTown(txtTown.Text);

            if (valid == false)
            {
                txtTown.Focus();
                MessageBox.Show("Incorrect Town");
            }
        }

        private void txtCounty_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateCounty(txtCounty.Text);

            if (valid == false)
            {
                txtCounty.Focus();
                MessageBox.Show("Incorrect County");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidatePhone(txtPhone.Text);

            if (valid == false)
            {
                txtPhone.Clear();
                txtPhone.Focus();
                MessageBox.Show("Incorrect Phone format");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = Validation.ValidateEmail(txtEmail.Text);

            if(valid == false)
            {
                txtEmail.Focus();
                MessageBox.Show("Incorrect Email address");
            }

        }
    }
}

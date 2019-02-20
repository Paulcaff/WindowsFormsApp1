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

            Boolean validTown= Validation.ValidateTown(txtTown.Text);

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

                int supplierId = Convert.ToInt16(Supplier.getNextSupplierId());
                string name = txtSupplierName.Text.ToUpper();
                string add1 = txtAddressLine1.Text;
                string add2 = txtAddressLine2.Text;
                string town = txtTown.Text;
                string county = txtCounty.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string status = "A";
                float balance = 0;

                Supplier newSupplier = new Supplier(supplierId, name, add1, add2, town, county, email, phone, status,balance);
                newSupplier.AddSupplier();

                MessageBox.Show("You have added a new Supplier");

                txtSupplierName.Clear();
                txtAddressLine1.Clear();
                txtAddressLine2.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEmail.Clear();
                txtPhone.Clear();

                txtSupplierId.Text = Supplier.getNextSupplierId().ToString("00000");
                txtSupplierName.Focus();

            }

            

           
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierId.Text =Supplier.getNextSupplierId().ToString("00000");
            txtSupplierName.Focus();
        }
 
    }
}

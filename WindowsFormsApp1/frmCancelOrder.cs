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
    }
}

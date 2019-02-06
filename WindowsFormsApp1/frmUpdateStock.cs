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
    public partial class frmUpdateStock : Form
    {
        frmMainMenu parent;
        public frmUpdateStock()
        {
            InitializeComponent();
        }

        public frmUpdateStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtstockName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

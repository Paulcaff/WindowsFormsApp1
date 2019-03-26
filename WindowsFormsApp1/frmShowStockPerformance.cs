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
    public partial class frmShowStockPerformance : Form
    {
        frmMainMenu parent;
        public frmShowStockPerformance()
        {
            InitializeComponent();
        }

        public frmShowStockPerformance(frmMainMenu Parent)
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

        private void frmShowStockPerformance_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.UtcNow.Year; i > (DateTime.UtcNow.Year - 4); i--)
            {
                cboYear.Items.Add(i);

            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (radioBest.Checked == true)
                dt = OrderItems.getBestWorstSellers(dt, cboYear.Text.Substring(2, 2), "DESC");
            else
                dt = OrderItems.getBestWorstSellers(dt, cboYear.Text.Substring(2, 2), "ASC");

            //load data from dt to form   
            Decimal[] quantity = new decimal[5];
            string[] StockName = new string[5];

            for (int i = 0; i < 5; i++)
            {
                int count = dt.Rows.Count;
                StockName[i] = dt.Rows[i][0].ToString();
            }


            for (int i = 0; i < 5; i++)
            {
                quantity[i] = Convert.ToDecimal(dt.Rows[i][1]);

            }


            //order the arrays N and M

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(StockName, quantity);
            //chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtData.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

            chtData.Titles.Clear();
            chtData.Titles.Add("Stock Performance");
            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "Stock Name";
            chtData.ChartAreas[0].AxisY.Title = "Amount";
            chtData.Series[0].IsVisibleInLegend = false;
            chtData.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chtData.Visible = true;
        }
    }
}
    


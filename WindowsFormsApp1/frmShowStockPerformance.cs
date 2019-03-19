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
           

            if(radioBest.Checked == true)
            {
                int year = Convert.ToInt32(cboYear.Text.Substring(2, 2));

                String strSQL = "SELECT StockName, SUM(RECEIVEDSTOCK) AS Total FROM OrderItems I JOIN Stock S ON I.StockID = S.StockID JOIN ORDERS O ON O.ORDERID = I.ORDERID WHERE OrderDate LIKE '%" + year + "' GROUP BY StockName ORDER BY Total DESC";
                DataTable dt = new DataTable();

                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);
                myConn.Close();

                Decimal[] quantity = new decimal[dt.Rows.Count];
                string[] StockName = new string[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int count = dt.Rows.Count;
                    StockName[i] =  dt.Rows[i][0].ToString();
                    MessageBox.Show(count + "    "+StockName[i].ToString());

                }


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int count = dt.Rows.Count;
                    quantity[i]= Convert.ToDecimal(dt.Rows[i][1]);
                    MessageBox.Show(count + "    " + quantity[i].ToString());
                }


                //order the arrays N and M

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtData.Series[0].LegendText = "Income in €";

                chtData.Series["Series1"]["PointWidth"] = ".5";

                chtData.Series["Series1"]["PixelPointWidth"] = "20";
                chtData.Series[0].Points.DataBindXY(StockName, quantity);
                chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                //chtSales.Series[0].Points[0] = "XXX";
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
            else
            {
                int year = Convert.ToInt32(cboYear.Text.Substring(2, 2));

                String strSQL = "SELECT StockName, SUM(RECEIVEDSTOCK) AS Total FROM OrderItems I JOIN Stock S ON I.StockID = S.StockID JOIN ORDERS O ON O.ORDERID = I.ORDERID WHERE OrderDate LIKE '%" + year + "' GROUP BY StockName ORDER BY Total ASC";
                DataTable dt = new DataTable();

                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);
                myConn.Close();

                Decimal[] quantity = new decimal[dt.Rows.Count];
                string[] StockName = new string[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    StockName[i] = dt.Rows[i][0].ToString();
                   
                    if(i == 5)
                    {
                        break;
                    }

                }


                for (int i = 0; i < dt.Rows.Count; i++)
                {                   
                    quantity[i] = Convert.ToDecimal(dt.Rows[i][1]);

                    if (i == 5)
                    {
                        break;
                    }
                }


                //order the arrays N and M

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtData.Series[0].LegendText = "Income in €";

                chtData.Series["Series1"]["PointWidth"] = ".5";

                chtData.Series["Series1"]["PixelPointWidth"] = "20";
                chtData.Series[0].Points.DataBindXY(StockName, quantity);
                chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                //chtSales.Series[0].Points[0] = "XXX";
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
        }
    


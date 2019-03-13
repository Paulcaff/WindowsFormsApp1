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
    public partial class frmShowBestSellers : Form
    {
        

        frmMainMenu parent;
        public frmShowBestSellers()
        {
            InitializeComponent();
        }

        public frmShowBestSellers(frmMainMenu Parent)
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

        private void frmShowBestSellers_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.UtcNow.Year; i > (DateTime.UtcNow.Year - 4); i--)
            {
                cboYears.Items.Add(i);

            }

        } 


    

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
                int year = Convert.ToInt32(cboYears.Text.Substring(2, 2));
                

                String strSQL = "SELECt SUM(OrderValue), To_CHAR(OrderDate, 'MM')  FROM Orders WHERE OrderDate LIKE '%" + year + "' GROUP BY To_CHAR(OrderDate, 'MM') ORDER BY To_CHAR(OrderDate, 'MM')";
                //String strSQL = "SELECt To_CHAR(OrderDate, 'MM'), SUM(OrderValue) FROM Orders WHERE OrderDate LIKE '%19' GROUP BY To_CHAR(OrderDate, 'MM') ORDER BY To_CHAR(OrderDate, 'MM')";
                DataTable dt = new DataTable();

                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);
                myConn.Close();

                string[] N = new string[dt.Rows.Count];            
                decimal[] M = new decimal[dt.Rows.Count];            

            for (int i = 0; i < 12; i++)
                {
                int currentMonth = i+1;

                if (currentMonth != (i + 1))
                {
                    N[i] = getMonth(currentMonth);
                    M[i] = 0;
                    MessageBox.Show("IF " + i);
                }
                else
                {
                    N[i] = getMonth(currentMonth);

                    M[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    MessageBox.Show("ELSE " + i);
                }
            }

                //order the arrays N and M

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtData.Series[0].LegendText = "Income in €";

                chtData.Series["Series1"]["PointWidth"] = ".5";

                chtData.Series["Series1"]["PixelPointWidth"] = "20";
                chtData.Series[0].Points.DataBindXY(N, M);
                chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

                chtData.Titles.Clear();
                chtData.Titles.Add("Yearly Revenue");
                //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
                chtData.ChartAreas[0].AxisX.Title = "MONTH";
                chtData.ChartAreas[0].AxisY.Title = "€'s";
                chtData.Series[0].IsVisibleInLegend = false;
                chtData.ChartAreas["ChartArea1"].AxisX.Interval = 1;


            chtData.Visible = true;
            }

            public String getMonth(int month)
            {
                switch (month)
                {
                    case 1:
                        {
                            return "JAN";

                        }
                    case 2:
                        {
                            return "FEB";

                        }
                    case 3:
                        {
                            return "MAR";

                        }
                    case 4:
                        {
                            return "APR";

                        }
                    case 5:
                        {
                            return "MAY";

                        }
                    case 6:
                        {
                            return "JUN";

                        }
                    case 7:
                        {
                            return "JUL";

                        }
                    case 8:
                        {
                            return "AUG";

                        }
                    case 9:
                        {
                            return "SEP";

                        }
                    case 10:
                        {
                            return "OCT";

                        }
                    case 11:
                        {
                            return "NOV";

                        }
                    case 12:
                        {
                            return "DEC";

                        }
                    default: return "OTH";

                }



            }

        
    }
}


using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Order
    {
        private int OrderId;
        private string OrderDate;
        private float OrderValue;
        private int SupplierId;
        private string Status;

        public Order()
        {
            OrderId = 0;
            OrderDate = "";
            OrderValue = 0.0f;
            SupplierId = 0;
            Status = "";
        }

        public Order(int OrderId,string OrderDate,float OrderValue, int SupplierId,string Status)
        {
            this.OrderId = OrderId;
            this.OrderDate = OrderDate;
            this.OrderValue = OrderValue;
            this.SupplierId = SupplierId;
            this.Status = Status;
        }

        public void setOrderId(int OrderId)
        {
            this.OrderId = OrderId;
        }

        public void setOrderDate(string OrderDate)
        {
            this.OrderDate = OrderDate;
        }

        public void setOrderValue(float OrderValue)
        {
            this.OrderValue = OrderValue;
        }

        public void setSupplierId(int SupplierId)
        {
            this.SupplierId = SupplierId;
        }

        public void setStatus(string Status)
        {
            this.Status = Status;
        }

        public int getOrderID()
        {
            return OrderId;
        }

        public string getOrderDate()
        {
            return OrderDate;
        }

        public float getOrderValue()
        {
            return OrderValue;
        }

        public int getSupplierId()
        {
            return SupplierId;
        }

        public string getStatus()
        {
            return Status;
        }

        public static int getNextOrderId()
        {
            int nextOrderId = 1;
            //Connect to DB
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            connect.Open();

            //define Sql Command
            String strSQL = "SELECT MAX(OrderId) FROM ORDERS";

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextOrderId = 1;
            else
                nextOrderId = Convert.ToInt16(dr.GetValue(0)) + 1;

            connect.Close();

            return nextOrderId;
        }

        public static DataSet getOrders(DataSet ds, int id)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "Select * From Orders Where SupplierId = " + id + " AND Status = 'O'";

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill The Dataset with query result;
            da.Fill(ds, "stk");

            //Close Db
            connect.Close();


            //return Query Result
            return ds;
        }

        public static DataSet getOrdersWithSupplierName(DataSet ds, int id)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            //String strSQL = "Select From Orders Where SupplierId = " + id + " AND Status = 'O'";
            String strSQL = "SELECT ORDERS.ORDERDATE,SUPPLIER.SUPPLIERNAME,ORDERS.ORDERVALUE,ORDERS.SUPPLIERID FROM ORDERS LEFT JOIN SUPPLIER ON ORDERS.SUPPLIERID = SUPPLIER.SUPPLIERID WHERE SUPPLIER.SUPPLIERID = "+id+" AND ORDERS.STATUS = 'O'";
            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill The Dataset with query result;
            da.Fill(ds, "stk");

            //Close Db
            connect.Close();


            //return Query Result
            return ds;
        }


        public static void getOrderStatus(int orderid)
        {
            MessageBox.Show("aaa" + orderid);
            
            //Connect to DB
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            connect.Open();

            //define Sql Command
            String strSQL = "SELECT Count(*) from OrderItems where Status = 'O' and ORDERID = "+orderid;

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (Convert.ToInt16(dr.GetValue(0))==0)
            {
                orderFullyReceived(orderid);
                
               

            }
            else {
                MessageBox.Show("OOOOOO");
            }

           

            connect.Close();

            
        }

        private static void orderFullyReceived(int orderid)
        {
            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
             String strSQL = "UPDATE ORDERS SET STATUS = 'R' WHERE ORDERID ="+orderid;

            

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();


        }





    }
}

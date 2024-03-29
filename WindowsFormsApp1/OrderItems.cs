﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class OrderItems
    {
        private int OrderId;
        private int StockId;
        private int Quantity;
        private float UnitPrice;

        public OrderItems()
        {
            OrderId = 0;
            StockId = 0;
            Quantity = 0;
            UnitPrice = 0.0f;
        }

        public OrderItems(int OrderId,int StockId,int Quantity, float UnitPrice)
        {
            this.OrderId = OrderId;
            this.StockId = StockId;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
        }

        private void setOrderId(int OrderId)
        {
            this.OrderId = OrderId;
        }

        public void setStockId(int StockId)
        {
            this.StockId = StockId;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        public void setUnitPrice(float UnitPrice)
        {
            this.UnitPrice = UnitPrice;
        }

        public int getStockId()
        {
            return StockId;
        }

        public int getOrderId()
        {
            return OrderId;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public float getUnitPrice()
        {
            return Quantity;
        }

        public static DataSet getOrderItems(DataSet ds, int id)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
             String strSQL = "SELECT ORDERITEMS.STOCKID,STOCK.STOCKNAME,ORDERITEMS.QUANTITY,ORDERITEMS.STATUS,ORDERITEMS.RECEIVEDSTOCK FROM ORDERITEMS INNER JOIN STOCK ON ORDERITEMS.STOCKID = STOCK.STOCKID WHERE ORDERITEMS.STATUS='O' AND ORDERID ="+id;
            
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

        public static DataSet getCancelItems(DataSet ds, int id)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "SELECT ORDERITEMS.STOCKID,STOCK.STOCKNAME,ORDERITEMS.QUANTITY,ORDERITEMS.STATUS FROM ORDERITEMS INNER JOIN STOCK ON ORDERITEMS.STOCKID = STOCK.STOCKID WHERE ORDERID =" + id;

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
        public static DataTable getBestWorstSellers(DataTable DT,String Year, String SortOrder)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT StockName, SUM(RECEIVEDSTOCK) AS Total FROM OrderItems I JOIN Stock S ON I.StockID = S.StockID JOIN ORDERS O ON O.ORDERID = I.ORDERID WHERE OrderDate LIKE '%" +
                Year + "' GROUP BY StockName ORDER BY Total " + SortOrder;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DT);
            myConn.Close();
            return DT;
        }


    }
}

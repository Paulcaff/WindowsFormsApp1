using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Stock
    {
        private int StockId;
        private string StockName;
        private string Description;
        private int Amount;
        private float Price;
        private int SupplierId;
        private string Status;

        public Stock()
        {
            StockId = 0;
            StockName = "";
            Description = "";
            Amount = 0;
            Price = 0.0f;
            SupplierId = 0;
            Status = "";
        }

        public Stock(int StockId, string StockName,string Description,int Amount,float Price,int SupplierId,string Status)
        {
            this.StockId =StockId;
            this.StockName= StockName;
            this.Description = Description;
            this.Amount = Amount;
            this.Price = Price;
            this.SupplierId = SupplierId;
            this.Status = Status;
        }

        public void setStockId(int StockId)
        {
            this.StockId = StockId;
        }

        public void setStockName(string StockName)
        {
            this.StockName = StockName;
        }

        public void setDescription(string Description)
        {
            this.Description = Description;
        }

        public void setAmount(int Amount)
        {
            this.Amount = Amount;
        }

        public void setPrice(float Price)
        {
            this.Price = Price;
        }

        public void setSupplierId(int SupplierId)
        {
            this.SupplierId = SupplierId;
        }

        public void setStatus(string Status)
        {
            this.Status = Status;
        }

        public int getStockId()
        {
            return StockId;
        }

        public string getStockName()
        {
            return StockName;
        }

        public string getDescription()
        {
            return Description;
        }

        public int getAmount()
        {
            return Amount;
        }

        public float getPrice()
        {
            return Price;
        }

        public int getSupplierId()
        {
            return SupplierId;
        }

        public string getStatus()
        {
            return Status;
        }

        public static DataSet getAllStock(DataSet ds)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "Select * From Stock";

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

        public void AddStock()
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
           // String strSQL1 = "INSERT INTO SUPPLIER VALUES(" + this.SupplierId + ",'" + this.SupplierName + "','" + this.AddressLine1 + "','" + this.AddressLine2 + "','" + this.Town + "','" + this.County + "','" + this.Email + "','" + this.Phone + "','" + this.Status + "')";
            
            String strSQL = "INSERT INTO Stock VALUES(" + this.StockId + ",'" + this.StockName + "','" + this.Description + "','" + this.Amount + "','" + this.Price + "','" + this.SupplierId + "','" + this.Status + "')";
            int a = getStockId();

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();


        }

        public static int getNextStockId()
        {
            int nextStockId = 1;
            //Connect to DB
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            connect.Open();

            //define Sql Command
            String strSQL = "SELECT MAX(StockId) FROM STOCK";

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextStockId = 1;
            else
                nextStockId = Convert.ToInt16(dr.GetValue(0)) + 1;

            connect.Close();

            return nextStockId;
        }


        public static DataSet getUpdateStock(DataSet ds, string search)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "Select * From Stock Where StockName LIKE '%" + search + "%'";

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




    }
}

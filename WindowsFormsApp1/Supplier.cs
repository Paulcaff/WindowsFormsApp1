using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Supplier
    {
        private int SupplierId;
        private string SupplierName;
        private string AddressLine1;
        private string AddressLine2;
        private string Town;
        private string County;
        private string Email;
        private string Phone;
        private string Status;

        //no argument constructor
        public Supplier()
        {
            SupplierId = 0;
            SupplierName = "";
            AddressLine1 = "";
            AddressLine2 = "";
            Town = "";
            County = "";
            Email = "";
            Phone = "";
            Status = "";

        }

        public Supplier(int SupplierId,string SupplierName,string AddressLine1,string AddressLine2,string Town,string County,string Email,string Phone,string Status)
        {
            this.SupplierId = SupplierId;
            this.SupplierName = SupplierName;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.Town = Town;
            this.County = County;
            this.Email = Email;
            this.Phone = Phone;
            this.Status = Status;

        }

        public void setSupplierId(int SupplierId)
        {
            this.SupplierId = SupplierId;
        }

        public void setSupplierName(string SupplierName)
        {
            this.SupplierName = SupplierName;
        }

        public void setAddressLine1(string AddressLine1)
        {
            this.AddressLine1 = AddressLine1;
        }

        public void setAddressLine2(string AddressLine2)
        {
            this.AddressLine2 = AddressLine2;
        }

        public void setTown(string Town)
        {
            this.Town = Town;
        }

        public void setCounty(string County)
        {
            this.County = County;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public void setPhone(string Phone)
        {
            this.Phone = Phone;
        }

        public void setStatus(string Status)
        {
            this.Status = Status;
        }

        public int getSupplierId()
        {
            return SupplierId;
        }

        public string getSupplierName()
        {
            return SupplierName;
        }

        public string getAddressLine1()
        {
            return AddressLine1;
        }

        public string getAddressLine2()
        {
            return AddressLine2;
        }

        public string getTown()
        {
            return Town;
        }

        public string getCounty()
        {
            return County;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getPhone()
        {
            return Phone;
        }
        public string getStatus()
        {
            return Status;
        }




        public static DataSet getAllSuppliers(DataSet ds)
        {
            
            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "Select * From Supplier";

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

        public void AddSupplier()
        {
           
            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "INSERT INTO SUPPLIER VALUES("+this.SupplierId+",'" + this.SupplierName + "','" + this.AddressLine1 + "','" + this.AddressLine2 + "','" + this.Town + "','" + this.County+ "','" +this.Email + "','" + this.Phone + "','"+this.Status+"')";
            int a = getSupplierId();

            //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            connect.Open();

            cmd.ExecuteNonQuery();
           
            connect.Close();
            

        }

        public static int getNextSupplierId()
        {
            int nextSupplierId = 1;
            //Connect to DB
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            connect.Open();

            //define Sql Command
            String strSQL = "SELECT MAX(SupplierId) FROM SUPPLIER";

             //Execute Query
            OracleCommand cmd = new OracleCommand(strSQL, connect);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextSupplierId = 1;
            else
                nextSupplierId = Convert.ToInt16(dr.GetValue(0)) + 1;

            connect.Close();

            return nextSupplierId;
        }


        public static DataSet getUpdateSupplier(DataSet ds,string search)
        {

            //connect to the db
            OracleConnection connect = new OracleConnection(DBConnect.oradb);

            //define Sql Command
            String strSQL = "Select * From Supplier Where SupplierName LIKE '%"+search+"%'" ;

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


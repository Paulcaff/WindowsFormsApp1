using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Validation
    {
        

        public static Boolean ValidateName(string name)
        {
            Boolean valid = false;
            var regexName = new Regex("^[a-zA-Z .]*$");
           
            if (!name.Equals(""))
            {
                if (regexName.IsMatch(name))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        public static Boolean ValidateAdd(string add)
        {
            Boolean valid = false;
            var regexAdd = new Regex("^[a-zA-Z0-9. ]*$");
            var regexNumber = new Regex("^[0-9 ]*$");

            if (!add.Equals(""))
            {
                if(regexAdd.IsMatch(add) && !regexNumber.IsMatch(add))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }


        public static Boolean ValidateTown(string town)
        {
            Boolean valid = false;
            var regexAdd = new Regex("^[a-zA-Z ]*$");

            if (!town.Equals(""))
            {
                if (regexAdd.IsMatch(town))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        public static Boolean ValidateCounty(string county)
        {
            Boolean valid = false;
            var regexAdd = new Regex("^[a-zA-Z. ]*$");

            if (!county.Equals(""))
            {
                if (regexAdd.IsMatch(county))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        public static Boolean ValidatePhone(string phone)
        {
            Boolean valid = false;
            var regexAdd = new Regex("^[0-9]*$");

            if (!phone.Equals(""))
            {
                if (regexAdd.IsMatch(phone))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }


        public static Boolean ValidateEmail(string email)
        {
            Boolean valid = false;
            var regexEmail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            //stackoverflow.com/questions/32985337/how-to-read-regex-in-my-email-validation-
            //This is the url where i got this Regex expression


            if (!email.Equals(""))
            {
                if (regexEmail.IsMatch(email))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }

        public static Boolean ValidateStatus(string status)
        {
            Boolean valid = false;
            var regexEmail = new Regex(@"^[a-zA-Z]");
            //stackoverflow.com/questions/32985337/how-to-read-regex-in-my-email-validation-
            //This is the url where i got this Regex expression


            if (!status.Equals(""))
            {
                if (status.Length == 1)
                {
                    if (regexEmail.IsMatch(status))
                    {
                        valid = true;
                    }

                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }


        public static Boolean ValidateId(string id)
        {
            Boolean valid = false;
            int Supplierid =Convert.ToInt16(id);
            

            String idCheck = "Select * from Supplier WHERE SupplierId = '" + Supplierid + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(idCheck, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
               
                valid = true;
            }
            else
            {
                MessageBox.Show("SupplierId does not exists in the Supplier database");
                //match
                
            }

            return valid;
        }


        public static Boolean ValidateAmount(string amount)
        {
            Boolean valid = false;
            var regexAdd = new Regex("^[0-9]+(.[0-9][0-9])?$");

            if (!amount.Equals(""))
            {
                if (regexAdd.IsMatch(amount))
                {
                    valid = true;
                }
            }

            else
            {
                valid = false;
            }

            return valid;
        }


       



    }
}

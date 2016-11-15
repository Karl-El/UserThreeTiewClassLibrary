using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessUserType
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnctStrng"].ConnectionString);

        public DataSet Select_UserType()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT USERTYPENAME FROM USERTYPE", Con);
            DataSet DS = new DataSet();
            SDA.Fill(DS);
            return DS;
        }

        public DataSet Select_UserPermit()
        {
            //SqlDataAdapter SDA = new SqlDataAdapter("SELECT USERTYPENAME FROM USERTYPE", Con);
            //DataSet DS = new DataSet();
            //SDA.Fill(DS);
            //return DS;

        }
    }
}

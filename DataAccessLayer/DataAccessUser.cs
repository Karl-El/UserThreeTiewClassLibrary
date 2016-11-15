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
    public class DataAccessUser
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnctStrng"].ConnectionString);

        public DataSet Select_User()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT USERS.USERID, USERS.USERNAME, USERS.EMAIL, USERS.USERPASS, USERTYPE.USERTYPENAME FROM USERS INNER JOIN USERTYPE ON USERS.USERTYPEID = USERTYPE.USERTYPEID", Con);
            DataSet DS = new DataSet();
            SDA.Fill(DS);
            return DS;
        }

        public void Insert_User(SqlCommand Cmd)
        {
            Con.Open();
            Cmd.Connection = Con;
            Cmd.CommandText = "INSERT INTO [USERS] ([USERNAME], [EMAIL], [USERPASS], [USERTYPEID]) VALUES (@USERNAME, @EMAIL, @USERPASS, @USERTYPEID)";
            Cmd.CommandType = CommandType.Text;
            Cmd.ExecuteNonQuery();
        }

        public void Update_User(SqlCommand Cmd)
        {
            Con.Open();
            Cmd.Connection = Con;
            Cmd.CommandText = "UPDATE [USERS] SET [USERNAME] = @USERNAME, [EMAIL] = @EMAIL, [USERPASS] = @USERPASS, [USERTYPEID] = @USERTYPEID WHERE [USERID] = @USERID";
            Cmd.CommandType = CommandType.Text;
            Cmd.ExecuteNonQuery();
        }

        public void Delete_User(SqlCommand Cmd)
        {
            Con.Open();
            Cmd.Connection = Con;
            Cmd.CommandText = "DELETE FROM [USERS] WHERE [USERID] = @USERID";
            Cmd.CommandType = CommandType.Text;
            Cmd.ExecuteNonQuery();
        }

    }
}

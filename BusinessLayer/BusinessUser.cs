using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BusinessUser
    {
        DataAccessUser DA = new DataAccessUser();
        SqlCommand Cmd = new SqlCommand();
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string User_Pass { get; set; }
        public int User_TypeID { get; set; }

        public DataSet UserSelect()
        {
            return DA.Select_User();
        }

        public void UserInsert()
        {
            Cmd.Parameters.AddWithValue("@USERID", User_Id);
            Cmd.Parameters.AddWithValue("@USERNAME", User_Name);
            Cmd.Parameters.AddWithValue("@EMAIL", User_Email);
            Cmd.Parameters.AddWithValue("@USERPASS", User_Pass);
            Cmd.Parameters.AddWithValue("@USERTYPEID", User_TypeID);
            DA.Insert_User(Cmd);
        }

        public void UserUpdate(int UserID)
        {
            Cmd.Parameters.AddWithValue("@USERID", User_Id);
            Cmd.Parameters.AddWithValue("@USERNAME", User_Name);
            Cmd.Parameters.AddWithValue("@EMAIL", User_Email);
            Cmd.Parameters.AddWithValue("@USERPASS", User_Pass);
            Cmd.Parameters.AddWithValue("@USERTYPEID", User_TypeID);
            DA.Update_User(Cmd);
        }

        public void UserDelete(int UserID)
        {
            Cmd.Parameters.AddWithValue("@USERID", User_Id);
            DA.Delete_User(Cmd);
        }
    }
}

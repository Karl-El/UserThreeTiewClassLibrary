using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;


namespace UsersWithThreeTierClassLibrary
{
    public partial class User : System.Web.UI.Page
    {
        string message = null;
        BusinessUser B_User = new BusinessUser();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindUser();
            }
        }

        public void BindUser()
        {
            _grdvwUser.DataSource = B_User.UserSelect();
            _grdvwUser.DataBind();
        }
        protected void _btnInsert_Click(object sender, EventArgs e)
        {
            B_User.User_Name = USERNAMETextBox.Text;
            B_User.User_Email = EMAILTextBox.Text;
            B_User.User_Pass = USERPASSTextBox.Text;
            B_User.User_TypeID = Convert.ToInt32(_ddlstUserType.SelectedValue);
            B_User.UserInsert();
            BindUser();
            message = "Record Inserted"; AlertAndClear();
        }

        protected void _btnUpdate_Click(object sender, EventArgs e)
        {
            B_User.User_Id = Convert.ToInt32(USERIDTextbox.Text);
            B_User.User_Name = USERNAMETextBox.Text;
            B_User.User_Email = EMAILTextBox.Text;
            B_User.User_Pass = USERPASSTextBox.Text;
            B_User.User_TypeID = Convert.ToInt32(_ddlstUserType.SelectedValue);
            B_User.UserUpdate(B_User.User_Id);
            BindUser();
            message = "Record Updated"; AlertAndClear();
        }

        protected void _btnDelete_Click(object sender, EventArgs e)
        {
            B_User.User_Id = Convert.ToInt32(USERIDTextbox.Text);
            B_User.UserDelete(B_User.User_Id);
            BindUser();
            message = "Record Deleted"; AlertAndClear();
        }

        public void AlertAndClear()
        {
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }
}
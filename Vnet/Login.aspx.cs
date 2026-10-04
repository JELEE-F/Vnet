using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string id = LIid.Text.Trim();
        string password = LIpassword.Text;

        UsersService us = new UsersService();

        if (us.IsExist(id, password))
        {
            Session["userName"] = us.GetFirstName(id);
            Session["loggedIn"] = true;
            Response.Redirect("Home.aspx");
        }
        else
        {
            LIlblError.Text = "ID or password are incorrect.";
        }
    }
}
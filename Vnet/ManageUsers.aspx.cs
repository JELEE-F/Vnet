using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UsersService us = new UsersService();
        GridUsers.DataSource = us.GetAllUsers();
        GridUsers.DataBind();
    }

   

    protected void GridUsers_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridUsers.EditIndex = e.NewEditIndex;
        UsersService us = new UsersService();
        GridUsers.DataSource = us.GetAllUsers();
        GridUsers.DataBind();
    }

    protected void GridUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridUsers.EditIndex = -1;
        UsersService us = new UsersService();
        GridUsers.DataSource = us.GetAllUsers();
        GridUsers.DataBind();
    }
}
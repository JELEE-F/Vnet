using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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

    protected void GridUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }

    protected void GridUsers_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView row = (DataRowView)e.Row.DataItem;
            RadioButtonList rblGender = (RadioButtonList)e.Row.FindControl("rblGender");
            DropDownList ddlCity = (DropDownList)e.Row.FindControl("ddlCity");

            // cities - same as the sign up page
            UsersService us = new UsersService();
            DataSet cities = us.GetAllCities();
            ddlCity.DataSource = cities;
            ddlCity.DataTextField = "city";
            ddlCity.DataValueField = "id";
            ddlCity.DataBind();

            // select the current city and gender of this user (1 = male, 2 = female)
            ddlCity.SelectedValue = row["CityId"].ToString();
            if (Convert.ToBoolean(row["Gender"]))
            {
                rblGender.SelectedValue = "1";
            }
            else
            {
                rblGender.SelectedValue = "2";
            }

            // only the row that is being edited can be changed
            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                rblGender.Enabled = true;
                ddlCity.Enabled = true;
            }
        }
    }
}
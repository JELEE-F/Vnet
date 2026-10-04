using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblFirstNameError.Text = "";
        lblLastNameError.Text = "";
        lblIdError.Text = "";
        lblPasswordError.Text = "";
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string firstName = SUfirstName.Text.Trim();
        string lastName = SUlastName.Text.Trim();
        string id = SUid.Text.Trim();
        string password = SUpassword.Text;
        int points = 0;
        int cityId = 1;

        bool isValid = true;

        // server side checks - a message under each field
        if (firstName == "")
        {
            lblFirstNameError.Text = "Please enter a first name.";
            isValid = false;
        }
        if (lastName == "")
        {
            lblLastNameError.Text = "Please enter a last name.";
            isValid = false;
        }
        if (password == "")
        {
            lblPasswordError.Text = "Please enter a password.";
            isValid = false;
        }

        // id checks: not empty, only digits, exactly 9 digits
        bool idFormatOk = true;
        if (id == "")
        {
            lblIdError.Text = "Please enter an ID.";
            idFormatOk = false;
        }
        else
        {
            bool onlyDigits = true;
            foreach (char c in id)
            {
                if (c < '0' || c > '9')
                {
                    onlyDigits = false;
                }
            }

            if (!onlyDigits || id.Length != 9)
            {
                lblIdError.Text = "ID must be a number with exactly 9 digits.";
                idFormatOk = false;
            }
        }

        if (!idFormatOk)
        {
            isValid = false;
        }

        UsersService us = new UsersService();

        // only ask the DB about the id if it is in a valid format
        if (idFormatOk && us.IsIdExist(id))
        {
            lblIdError.Text = "This ID is already registered.";
            isValid = false;
        }

        if (isValid)
        {
            User u1 = new User(firstName, lastName, id, password, points, cityId);
            u1.insertIntoDB();
            Session["userName"] = firstName;
            Session["loggedIn"] = true;

            Response.Redirect("Home.aspx");
        }
    }
}
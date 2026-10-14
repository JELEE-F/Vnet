using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblFirstNameError.Text = "";
        lblLastNameError.Text = "";
        lblIdError.Text = "";
        lblPhoneError.Text = "";
        lblGenderError.Text = "";
        lblCityError.Text = "";
        lblPasswordError.Text = "";


        if (!IsPostBack)
        {
            UsersService us = new UsersService();
            DataSet cities = us.GetAllCities();

            SUcity.DataSource = cities;
            SUcity.DataTextField = "city";
            SUcity.DataValueField = "id";
            SUcity.DataBind();
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string firstName = SUfirstName.Text.Trim();
        string lastName = SUlastName.Text.Trim();
        string id = SUid.Text.Trim();
        string phone = SUphone.Text.Trim();
        string password = SUpassword.Text;
        bool gender = false;
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

        // city: the dropdown value is the city id from the cities table (empty only if the table has no rows)
        if (SUcity.SelectedValue == "")
        {
            lblCityError.Text = "Please select a city.";
            isValid = false;
        }
        else
        {
            cityId = int.Parse(SUcity.SelectedValue);
        }

        // gender: nothing selected -> message, otherwise 1 = male (true), else female (false)
        if (Gender.SelectedItem == null)
        {
            lblGenderError.Text = "Please select a gender.";
            isValid = false;
        }
        else
        {
            if (Gender.SelectedItem.Value.Equals("1"))
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
        }

        // phone checks: not empty, only digits, 9 or 10 digits
        if (phone == "")
        {
            lblPhoneError.Text = "Please enter a phone number.";
            isValid = false;
        }
        else
        {
            bool phoneOnlyDigits = true;
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    phoneOnlyDigits = false;
                }
            }

            if (!phoneOnlyDigits || phone.Length < 9 || phone.Length > 10)
            {
                lblPhoneError.Text = "Phone number must contain only digits (9 or 10 digits).";
                isValid = false;
            }
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
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
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
            User u1 = new User(firstName, lastName, id, phone, gender, password, points, cityId);
            u1.insertIntoDB();
            Session["userName"] = firstName;
            Session["loggedIn"] = true;

            Response.Redirect("Home.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    private int id;
    private string firstName;
    private string lastName;
    private string identification;
    private string phoneNumber;
    private string email;
    private bool gender;
    private string password;
    private int points;
    private int cityId;

    public User()
    {
        this.id = 0;
        this.firstName = "";
        this.lastName = "";
        this.identification = "";
        this.phoneNumber = "";
        this.email = "";
        this.gender = true;
        this.password = "";
        this.points = 0;
        this.cityId = 0;
    }

    public User(string firstName, string lastName, string identification, string phoneNumber, string email, bool gender, string password, int points, int cityId)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.identification = identification;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.gender = gender;
        this.password = password;
        this.points = points;
        this.cityId = cityId;
    }

    public void insertIntoDB()
    {
        //connect to DB
        //insert current user data into users table
        UsersService us = new UsersService();
        us.insertIntoDB(this.firstName, this.lastName, this.identification, this.phoneNumber, this.email, this.gender, this.password, this.points, this.cityId);
    }
}
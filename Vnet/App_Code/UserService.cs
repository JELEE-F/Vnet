using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for UsersService
/// </summary>
public class UsersService
{
    static OleDbConnection myConnection;
    public UsersService()
    {
        string connectionString = Connect.GetConnectionString();
        myConnection = new OleDbConnection(connectionString);
    }

    public void insertIntoDB(string firstName, string lastName, string identification, string password, int points, int cityId)
    {
        try
        {
            myConnection.Open();
            string sSql = "INSERT INTO Users (FirstName, LastName, Identification, [Password], Points, CityId) " +
                          "VALUES ('" + firstName + "', '" + lastName + "', '" + identification + "', '" + password + "', " + points + ", " + cityId + ")";

            OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myConnection.Close();
        }
    }

    // used by the login page: does a user with this first name AND password exist?
    // used by the login page: does a user with this id AND password exist?
    public bool IsExist(string identification, string password)
    {
        DataSet dataset = new DataSet();
        try
        {
            myConnection.Open();
            string sSql = "SELECT * FROM Users WHERE Identification = '" + identification + "' AND [Password] = '" + password + "';";
            OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = myCmd;
            adapter.Fill(dataset, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myConnection.Close();
        }

        return dataset.Tables[0].Rows.Count > 0;
    }

    // used by the sign up page: is this id already registered?
    public bool IsIdExist(string identification)
    {
        DataSet dataset = new DataSet();
        try
        {
            myConnection.Open();
            string sSql = "SELECT * FROM Users WHERE Identification = '" + identification + "';";
            OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = myCmd;
            adapter.Fill(dataset, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myConnection.Close();
        }

        return dataset.Tables[0].Rows.Count > 0;
    }

    // used after a successful login: get the first name of the user with this id
    public string GetFirstName(string identification)
    {
        DataSet dataset = new DataSet();
        try
        {
            myConnection.Open();
            string sSql = "SELECT FirstName FROM Users WHERE Identification = '" + identification + "';";
            OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = myCmd;
            adapter.Fill(dataset, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myConnection.Close();
        }

        return dataset.Tables[0].Rows[0]["FirstName"].ToString();
    }
}
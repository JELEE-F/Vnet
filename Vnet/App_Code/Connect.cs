using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connect
/// </summary>
public class Connect
{
    private const string DB = "VnetDB.accdb";

    public static string GetConnectionString()
    {
        string location = HttpContext.Current.Server.MapPath("~/App_Data/" + DB);
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + location;
        return connectionString;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3.Manager
{
    public class General_Manager
    {
        public static string connectionString = @"Data Source=(local);Initial Catalog=Final_DBMS_Project;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connectionString);

        //public General_Manager()
        //{
        //    if (con.State == ConnectionState.Open)
        //    {
        //        con.Close();
        //    }
        //    con.Open();
        //}
    }
}
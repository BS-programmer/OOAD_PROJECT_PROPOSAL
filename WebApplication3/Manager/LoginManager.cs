using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication3.Manager;
using WebApplication3.Models;
using System.Data;
using System.Data.Entity;

namespace WebApplication3.Manager
{
    public class LoginManager:General_Manager
    {

        public LoginModel checkLogin(string name, string pass)
        {
            using (Final_DBMS_ProjectEntities db = new Final_DBMS_ProjectEntities())
            {
                //login_table lg_t = new login_table();
                // db.login_table.Where(x ==> x.Username == name, x ==> x.Password == pass, x => x.Type == type) as Single; 
                try
                {
                    var request = db.login_table.Where(x => x.Username == name && x.Password == pass).FirstOrDefault();
                    LoginModel user = new LoginModel();
                    user.ID = request.ID;
                    user.Username = request.Username;
                    user.type = request.Type;
                    user.Password = request.Password;
                    return user;
                }catch(Exception ex)
                {
                    return new LoginModel();
                }            

            }
        }


        //public string[] loginpanel()
        //{
        //    string query = "select * from Login_table ";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    string[] data = new string[2];
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        data[0] = reader[1].ToString();
        //        data[1] = reader[2].ToString();
                
        //    }
        //    con.Close();
            
        //    return data;
        //}
        //public string[] loginpanel_cust()
        //{
        //    string query = "select * from Login_table_cust";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    string[] data = new string[2];
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        data[0] = reader[1].ToString();
        //        data[1] = reader[2].ToString();

        //    }
        //    con.Close();

        //    return data;
        //}
        
    }
}
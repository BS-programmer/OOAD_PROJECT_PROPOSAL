using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication3.Manager;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.Manager
{
    public class checkout_manager:General_Manager
    {
        public int Checking(Checkout_Model cm)
        {
            int sid = 0;
            using (Final_DBMS_ProjectEntities db = new Final_DBMS_ProjectEntities())
            {
                CheckOut ch_tbl = new CheckOut();
                ch_tbl.FirstName = cm.FirstName;
                ch_tbl.LastName = cm.LastName;
                ch_tbl.Email = cm.Email;
                ch_tbl.Address = cm.Address;
                ch_tbl.CompanyName = cm.CompanyName;
                ch_tbl.ContactNumber = cm.ContactNumber;
                ch_tbl.Town = cm.Town;
                ch_tbl.Zipcode = cm.Zipcode;
                db.CheckOuts.Add(ch_tbl);
                db.SaveChanges();
                sid = ch_tbl.ID;
            }
            return sid;

        }
    }
}
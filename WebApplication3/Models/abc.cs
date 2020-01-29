using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication3.Models
{
    public class abc:DbContext
    {
        public abc()
            : base("cs")
        { 
        
        }

        public DbSet<Reservation> reservations { get; set; }
        public DbSet<LoginModel> LoginModel{ get; set; }
        public DbSet<Pkg> Packages { get; set; }
        public DbSet<Services> servicess { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
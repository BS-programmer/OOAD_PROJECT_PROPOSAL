using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;
using System.Data.Entity;

namespace WebApplication3.Manager
{
    public partial class add_productManager
    {
        public int productID { get; set; }
        public string productName { set; get; }
        public int productprice { set; get; }
        public string productimageURL { set; get; }
        public HttpPostedFileBase Image { get; set; }
    }
}
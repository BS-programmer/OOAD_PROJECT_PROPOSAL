using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication3.Models
{
    public class AddproductModel
    {
        public int productID { get; set; }
        public string productName { set; get; }
        public int productprice { set; get; }
        public string productimageURL { set; get; }
        public HttpPostedFileBase Image { get; set; }


    }
}
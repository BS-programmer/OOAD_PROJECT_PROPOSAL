using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Manager;
using WebApplication3.Models;
using System.Data.Entity;

namespace WebApplication3.Manager
{
    public class product_manager
    {
        public List<AddproductModel> selectproduct()
        {
            using (Final_DBMS_ProjectEntities db = new Final_DBMS_ProjectEntities())
            {
                var request = db.Addproducts.ToList();
                List<AddproductModel> List = request.Select(x => new AddproductModel { productID = x.productid, productName = x.productname, productimageURL = x.productimage.ToString(), productprice = Convert.ToInt32(x.productprice)}).ToList();
                return List;
            }

        
        }
       // public 
    }
}
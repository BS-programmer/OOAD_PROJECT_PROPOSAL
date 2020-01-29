using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Manager;
using WebApplication3.Models;
using System.Data.Entity;
namespace WebApplication3.Manager

{
    public class Add_to_cartManager
    {
        public List<Add_to_cartModel> add_to_cartMethod()
        {
            using (Final_DBMS_ProjectEntities db = new Final_DBMS_ProjectEntities())
            {
                var request = db.Addproducts.ToList();
                List<Add_to_cartModel> List = request.Select(x => new Add_to_cartModel { productID = x.productid, productName = x.productname, productimageURL = x.productimage.ToString(), productprice = Convert.ToInt32(x.productprice) }).ToList();
                return List;
            }
        }
        public AddproductModel GetPID(int PID)
        {
            using (Final_DBMS_ProjectEntities DB = new Final_DBMS_ProjectEntities())
            {
                var Request = DB.Addproducts.Where(x => x.productid == PID).FirstOrDefault();
                AddproductModel product_update = null;
                if (Request != null)
                {
                    product_update = new AddproductModel()
                    {
                        productID = Request.productid,
                        productName = Request.productname,
                        productprice = Convert.ToInt32(Request.productprice),
                        //productimageURL=Request.productimage,
                    };
                    return product_update;
                }
                else
                {
                    return product_update;
                }
            }
        }
        public bool UpdateStd(AddproductModel ProductModel)
        {
            using (Final_DBMS_ProjectEntities DB = new Final_DBMS_ProjectEntities())
            {
                var Data = DB.Addproducts.Where(x => x.productid == ProductModel.productID).FirstOrDefault();
                if (Data != null)
                {
                    Data.productid = ProductModel.productID;
                    Data.productname = ProductModel.productName;
                    Data.productprice = Convert.ToString(ProductModel.productprice);
                   // Data.productimage = ProductModel.productimageURL;
                    DB.Entry(Data).State = EntityState.Modified;
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool DeleteStd(int id)
        {
            using (Final_DBMS_ProjectEntities DB = new Final_DBMS_ProjectEntities())
            {
                var Data = DB.Addproducts.Where(x => x.productid == id).FirstOrDefault();
                if (Data != null)
                {
                    DB.Entry(Data).State = EntityState.Deleted;
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
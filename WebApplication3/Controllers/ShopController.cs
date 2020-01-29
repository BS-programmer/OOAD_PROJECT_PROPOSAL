using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Manager;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    [Filter.AuthorizeUrl]
    public class ShopController : Controller
    {
        
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SHOP()
        {
            return View();
        }
        public ActionResult Bed()
        {
            product_manager ap_manager = new product_manager();
            List<AddproductModel> add_products = ap_manager.selectproduct();
            return View(add_products);
        }
        


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Manager;

namespace WebApplication3.Controllers
{
    [Filter.AuthorizeUrl]
    public class ProductController : Controller
    {
       
       
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult product()
        {
            return View();
        }
        public ActionResult Beds()
        {
            Add_to_cartManager atc = new Add_to_cartManager();
            List<Add_to_cartModel> AddToCart = atc.add_to_cartMethod();
            return View(AddToCart);
        }
        public ActionResult Add_to_cart()
        {

            return View();
        }

    }
}
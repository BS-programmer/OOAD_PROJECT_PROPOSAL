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
    public class CheckoutController : Controller
    {
        checkout_manager cmg_obj = new checkout_manager();
        
        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult checkout()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult checkout(Checkout_Model cmm)
        {
            if (ModelState.IsValid)
            {
                int a = cmg_obj.Checking(cmm);
                if (a > 0)
                {
                    ViewBag.Message = "Data Inserted";
                }
                else
                {
                    ViewBag.Message = "Not Inserted";
                }
            }
            else
            {
                ViewBag.Message = "Please Insert Data";
            }

            return View();
        }
      
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    [Filter.AuthorizeUrl]
    public class CARTController : Controller
    {
       [Filter.AuthorizeUrl]
        // GET: CART
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }

    }
}
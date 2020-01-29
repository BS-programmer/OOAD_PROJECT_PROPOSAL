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
    
    public class deshboardController : Controller
    {
        
        // GET: deshboard
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult deshBoard()
        {
            return View();
        }
        public ActionResult DESH_BOARD()
        {
            return View();
        }
        
    }
}
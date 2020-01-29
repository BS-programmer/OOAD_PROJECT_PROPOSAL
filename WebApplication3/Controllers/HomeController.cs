using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(string username, string password)
        //{
        //    if (username == "user" && password == "123")
        //    {
        //        Session["IsLogedIn"] = true;
        //        return RedirectToAction("DESH_BOARD", "deshboard");
        //    }
        //    else if (username == "Admin" && password == "321")
        //    {
        //        Session["AdminIsLogedIn"] = true;
        //        return RedirectToAction("deshBoard", "deshboard");
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Username or Password is incorrect";
        //        return View();
        //    }

        //}
        //public ActionResult Logout()
        //{
        //    Session.Clear();
        //    return RedirectToAction("Index", "Admin");
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using WebApplication3.Manager;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        ////public ActionResult Index()
        ////{
        ////    return View();
        ////}


        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(LoginModel lg_model)
        {
            if(ModelState.IsValid)
            {
                LoginManager lg_manager = new LoginManager();
                LoginModel user = lg_manager.checkLogin(lg_model.Username, lg_model.Password);
                if (user.type == 1)
                {
                    Session["IsLogedIn"] = true;
                    Session["LoginID"] = user.ID;
                    Session["LoginType"] = user.type;
                    return RedirectToAction("DESH_BOARD", "deshboard");
                }
                else if (user.type == 2)
                {
                    Session["IsLogedIn"] = true;
                    return RedirectToAction("deshBoard", "deshboard");
                }
            }
            else
            {
                ViewBag.Message = "Username or password is incorrect";
                return View();
            }
            ViewBag.Message = "Username or password is incorrect";
            return  View();
        }
        
        
    
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("login", "Login");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Manager;
using WebApplication3.Models;
using System.Threading;
using System.Timers;
using System.Data.Entity;
using System.IO;


namespace WebApplication3.Controllers
{
    public class Add_productController : Controller
    {
        Add_to_cartManager obj = new Add_to_cartManager();
        // GET: Add_product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult add_product()
        {
            return View();
        } 
        
        [HttpPost]
        public ActionResult add_product(Addproduct adding)
        {
            //string path = System.IO.Path.Combine("~/Content/iamges)

            string FileName = Path.GetFileNameWithoutExtension(adding.Image.FileName);
            string extension = Path.GetExtension(adding.Image.FileName);
            FileName = FileName+DateTime.Now.ToString("yyyyMMdd") + extension;
            adding.productimage = "~/Images/" + FileName;

            FileName = Path.Combine(Server.MapPath("~/Images/"), FileName);
            adding.Image.SaveAs(FileName);
            using (Final_DBMS_ProjectEntities db = new Final_DBMS_ProjectEntities())
            {
                db.Addproducts.Add(adding);
                db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateBed(int Pid)
        {
            AddproductModel AddPromo = obj.GetPID(Pid);
            if (AddPromo == null)
            {
                ViewBag.Message = "Data Not Fount";
                return RedirectToAction("Bed");
            }
            else
            {
                ViewBag.Message = " ";
            }
            return View(AddPromo);
        }
        [HttpPost]
        public ActionResult UpdateBed(AddproductModel adm)
        {
            if (ModelState.IsValid)
            {
                bool check = obj.UpdateStd(adm);
                if (check)
                {
                    ViewBag.Message = "Data doesn't Update Successfully";
                    return RedirectToAction("Bed", "Shop");
                }
                else
                {
                    ViewBag.Message = "Data doesn't Update Successfully";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Data doesn't Update Successfully";
                return View();
            }
        }
        public ActionResult DeleteBed(int pid)
        {
            bool Check = obj.DeleteStd(pid);
            if (Check)
            {
                ViewBag.Message = "Data Deleted Successfully";
            }
            else
            {
                ViewBag.Message = "Error";
            }
            return RedirectToAction("Bed","Shop");
            return View();
        }
    }
}
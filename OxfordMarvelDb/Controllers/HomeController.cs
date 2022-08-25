using OxfordMarvelDb.Models.DB_Model;
using OxfordMarvelDb.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OxfordMarvelDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customers newcustomer)
        {
            try
            {
                var db = new OxfordDb();
                var cust = new customer();
                cust.ContactName = newcustomer.CustomerName;
                cust.City = newcustomer.City;
                cust.Country = newcustomer.Country;
                db.customers.Add(cust);
                db.SaveChanges();
                return RedirectToAction("SuccessfulRegistration");
            }
            catch (Exception Ex)
            {

                ViewBag.ErrorMessage = "Unsuccessful Registration";
                return View();
            }

           
        }

        public ActionResult SuccessfulRegistration()
        {
            return View();
        }
    }
}
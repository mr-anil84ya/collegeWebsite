using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUS()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(string r)
        {
      
            if (r.InsertData() == true)
            {
                Response.Write("<script>alert('Registration Successful')</script>");
            }
            else
            {
                Response.Write("<script>alert('Registration Failed')</script>");
            }
            return View();
           
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ABoards()
        {
            return View();
        }
    }
}

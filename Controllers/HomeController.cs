using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }  
        
        // GET: Home/Columns
        public ActionResult Columns()
        {
            return View();
        }
        // GET: Home/Left

        public ActionResult LeftSideBar()
        {
            return View();
        }  
        public ActionResult rightSidebar()
        {
            return View();
        }
        
        public ActionResult withoutSidebar()
        {
            return View();
        }


        

    }
}
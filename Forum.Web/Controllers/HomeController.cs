using Forum.Infrastructure.Context;
using Forum.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            return View();
        }  
    }
}
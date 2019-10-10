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
        private readonly TopicService _postService;
        public HomeController(TopicService postService)
        {
            _postService = postService;
        }
        public ActionResult Index()
        {
            var result = _postService.GetPosts();
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
    }
}
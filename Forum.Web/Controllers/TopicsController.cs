using Forum.Infrastructure.Services;
using System.Web.Mvc;

namespace Forum.Web.Controllers
{
    public class TopicsController : Controller
    {
        private readonly TopicService _topicsService;

        public TopicsController(TopicService topicsService)
        {
            _topicsService = topicsService;
        }

        public ActionResult Index()
        {
            return View();
        }
        // GET: Topics
        [HttpGet]
        public JsonResult GetTopics(string searchText)
        {
            var result = _topicsService.GetPosts(searchText);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
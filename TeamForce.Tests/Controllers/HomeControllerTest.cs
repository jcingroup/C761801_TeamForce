using System.Web.Mvc;

namespace Work.WebProj.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            ViewBag.IsFirstPage = false;
        }

        public ActionResult Index()
        {
            return View();
        }

        // 公司簡介
        public ActionResult AboutUs()
        {
            return View();
        }

        // 服務項目
        public ActionResult Service()
        {
            return View();
        }

        // 公司實績
        public ActionResult Perform()
        {
            return View();
        }

        // 聯絡我們
        public ActionResult Contact()
        {
            return View();
        }

        // 相關連結
        public ActionResult Connect()
        {
            return View();
        }

        public ActionResult Introduction()
        {
            return View();
        }        
    }
}

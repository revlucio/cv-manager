using System.Collections.Generic;
using System.Web.Mvc;
using CvManager.Business;
using CvManager.Model;

namespace CvManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Cv()
        {
            var cvGenerator = new CvGenerator();

            return View(cvGenerator.GetElizabethsCv());
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
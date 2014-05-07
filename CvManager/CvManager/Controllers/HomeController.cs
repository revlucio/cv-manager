using CvManager.Model;
using System.Web.Mvc;

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
            var repository = new CvRepository();

            return View(repository.GetElizabethsCv());
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
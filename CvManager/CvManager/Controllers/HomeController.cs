using CvManager.Model;
using System.Web.Mvc;

namespace CvManager.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Cv()
        {
            var repository = new CvRepository();

            return View(repository.GetElizabethsCv());
        }

        [HttpGet]
        public ViewResult CvEdit()
        {
            var repository = new CvRepository();

            return View(repository.GetElizabethsCv());
        }

        [HttpPost]
        public ViewResult CvEdit(Cv cv)
        {
            var repository = new CvRepository();

            return View(repository.SaveNewCv(cv));
        }
    }
}
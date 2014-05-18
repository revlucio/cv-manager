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
            var cv = repository.GetElizabethsCv();

            return View(cv);
        }

        [HttpPost]
        public ViewResult CvEdit(Cv cv)
        {
            var repository = new CvRepository();

            return View(repository.SaveNewCv(cv));
        }

        [HttpPost]
        public ActionResult AddAchievement(Cv cv)
        {
            cv.Achievements.Add(new Achievement());
            
            return PartialView("~/Views/Shared/EditorTemplates/AchievementList.cshtml", cv);
        }

        [HttpGet]
        public ActionResult RemoveAchievement(int id)
        {
            var repository = new CvRepository();
            var cv = repository.GetElizabethsCv();
            cv.Achievements.RemoveAt(id);
            repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/AchievementList.cshtml", cv);
        }
    }
}
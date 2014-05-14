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

            TempData["AchievementId"] = cv.Achievements.Count;

            return View(cv);
        }

        [HttpPost]
        public ViewResult CvEdit(Cv cv)
        {
            var repository = new CvRepository();

            TempData["AchievementId"] = cv.Achievements.Count;

            return View(repository.SaveNewCv(cv));
        }


        [HttpGet]
        public ActionResult AddAchievement()
        {
            var id = int.Parse(TempData["AchievementId"].ToString());

            TempData["AchievementId"] = id + 1;

            return PartialView("~/Views/Shared/_Achievement.cshtml", new Achievement { Id = id });
        }

        [HttpPost]
        public ActionResult AddAchievement(Cv cv)
        {
            cv.Achievements.Add(new Achievement());
            
            return PartialView("~/Views/Shared/EditorTemplates/AchievementList.cshtml", cv.Achievements);
        }
    }
}
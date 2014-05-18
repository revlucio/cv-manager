using CvManager.Model;
using System.Web.Mvc;

namespace CvManager.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Cv()
        {
            var repository = new CvRepository();

            return View(repository.GetElizabethsCv());
        }

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

        [HttpPost]
        public ActionResult AddEducation(Cv cv)
        {
            cv.Educations.Add(new Education());

            return PartialView("~/Views/Shared/EditorTemplates/EducationList.cshtml", cv);
        }

        [HttpGet]
        public ActionResult RemoveEducation(int id)
        {
            var repository = new CvRepository();
            var cv = repository.GetElizabethsCv();
            cv.Educations.RemoveAt(id);
            repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/EducationList.cshtml", cv);
        }

        [HttpPost]
        public ActionResult AddWorkExperience(Cv cv)
        {
            cv.WorkExperiences.Add(new WorkExperience());

            return PartialView("~/Views/Shared/EditorTemplates/WorkExperienceList.cshtml", cv);
        }

        [HttpGet]
        public ActionResult RemoveWorkExperience(int id)
        {
            var repository = new CvRepository();
            var cv = repository.GetElizabethsCv();
            cv.WorkExperiences.RemoveAt(id);
            repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/WorkExperienceList.cshtml", cv);
        }
    }
}
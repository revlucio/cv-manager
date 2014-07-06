using CvManager.Model;
using System.Web.Mvc;

namespace CvManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly CvRepository _repository;

        public HomeController()
        {
            _repository = new CvRepository();
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Cv()
        {
            return View(_repository.GetElizabethsCv());
        }

        public ViewResult CvEdit()
        {
            var cv = _repository.GetElizabethsCv();

            return View(cv);
        }

        [HttpPost]
        public RedirectToRouteResult CvEdit(Cv cv)
        {
            _repository.SaveNewCv(cv);

            return RedirectToAction("CvEdit", "Home");
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
            var cv = _repository.GetElizabethsCv();
            cv.Achievements.RemoveAt(id);
            _repository.SaveNewCv(cv);

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
            var cv = _repository.GetElizabethsCv();
            cv.Educations.RemoveAt(id);
            _repository.SaveNewCv(cv);

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
            var cv = _repository.GetElizabethsCv();
            cv.WorkExperiences.RemoveAt(id);
            _repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/WorkExperienceList.cshtml", cv);
        }

        [HttpPost]
        public ActionResult AddConference(Cv cv)
        {
            cv.Conferences.Add(new Conference());

            return PartialView("~/Views/Shared/EditorTemplates/ConferenceList.cshtml", cv);
        }

        [HttpGet]
        public ActionResult RemoveConference(int id)
        {
            var cv = _repository.GetElizabethsCv();
            cv.Conferences.RemoveAt(id);
            _repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/ConferenceList.cshtml", cv);
        }

        [HttpPost]
        public ActionResult AddReference(Cv cv)
        {
            cv.References.Add(new Reference());

            return PartialView("~/Views/Shared/EditorTemplates/ReferenceList.cshtml", cv);
        }

        [HttpGet]
        public ActionResult RemoveReference(int id)
        {
            var cv = _repository.GetElizabethsCv();
            cv.References.RemoveAt(id);
            _repository.SaveNewCv(cv);

            return PartialView("~/Views/Shared/EditorTemplates/ReferenceList.cshtml", cv);
        }
    }
}
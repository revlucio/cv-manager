using CvManager.Business;
using System.Data.Entity;
using System.Linq;

namespace CvManager.Model
{
    public class CvRepository
    {
        private readonly CvContext _context;

        public CvRepository()
        {
            _context = new CvContext();
        }

        public Cv GetElizabethsCv()
        {
            return _context.Cvs
                .Include(cv => cv.Achievements)
                .Include(cv => cv.Educations)
                .Include(cv => cv.WorkExperiences)
                .Include(cv => cv.Conferences)
                .Include(cv => cv.References)
                .First(cv => cv.FullName == "Elizabeth L. Knox");
        }

        public Cv SaveNewCv(Cv newCv)
        {
            var cv = GetElizabethsCv();

            cv.Email = newCv.Email;
            cv.Website = newCv.Website;
            cv.PhoneNumber = newCv.PhoneNumber;

            cv.Educations = newCv.Educations;
            cv.WorkExperiences = newCv.WorkExperiences;
            cv.Achievements = newCv.Achievements;
            cv.Skills = newCv.Skills;
            cv.Fieldwork = newCv.Fieldwork;
            cv.Conferences = newCv.Conferences;

            _context.SaveChanges();

            return cv;
        }

        public void CreateNewCv()
        {
            var generator = new CvGenerator();
            _context.Cvs.Add(generator.GetElizabethsCv());
            _context.SaveChanges();
        }
    }
}
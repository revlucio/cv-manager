using CvManager.Business;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            var lizsCv = _context.Cvs
                .Include(cv => cv.Achievements)
                .Include(cv => cv.Educations)
                .Include(cv => cv.WorkExperiences)
                .Include(cv => cv.Conferences)
                .Include(cv => cv.References)
                .OrderByDescending(cv => cv.LastModifiedDateTime)
                .FirstOrDefault(cv => cv.IsLive);

            lizsCv = lizsCv ?? new Cv();

            return lizsCv;
        }

        public Cv SaveNewCv(Cv newCv)
        {
            newCv.LastModifiedDateTime = DateTime.Now;
            newCv.IsLive = true;
            
            newCv.Educations.ForEach(e => SetItem(e, newCv.Id));
            newCv.Achievements.ForEach(e => SetItem(e, newCv.Id));
            newCv.WorkExperiences.ForEach(e => SetItem(e, newCv.Id));
            newCv.References.ForEach(e => SetItem(e, newCv.Id));
            newCv.Conferences.ForEach(e => SetItem(e, newCv.Id));
            
            _context.Cvs.AddOrUpdate(newCv);
            _context.SaveChanges();
            return newCv;
        }

        private void SetItem(CvSection item, int cvId)
        {
            item.CvId = cvId;
            _context.Entry(item).State = (item.Id == 0)
                ? EntityState.Added
                : EntityState.Modified;
        }

        public void CreateNewCv()
        {
            var generator = new CvGenerator();
            _context.Cvs.Add(generator.GetElizabethsCv());
            _context.SaveChanges();
        }
    }
}
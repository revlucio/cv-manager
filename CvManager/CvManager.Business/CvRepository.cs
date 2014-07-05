using CvManager.Business;
using System;
using System.Collections.Generic;
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
            var lizsCv = _context.Cvs
                .Include(cv => cv.Achievements)
                .Include(cv => cv.Educations)
                .Include(cv => cv.WorkExperiences)
                .Include(cv => cv.Conferences)
                .Include(cv => cv.References)
                .OrderByDescending(cv => cv.LastModifiedDateTime)
                .FirstOrDefault(cv => cv.IsLive);

            //lizsCv.Educations = lizsCv.Educations.OrderByDescending(e => e.ConvertEndTime()).ToList();

            lizsCv = lizsCv ?? new Cv();

            return lizsCv;
        }

        public Cv SaveNewCv(Cv newCv)
        {
            newCv.LastModifiedDateTime = DateTime.Now;
            newCv.IsLive = true;

            _context.Entry(newCv).State = EntityState.Modified;
            UpdateItems(newCv.Educations);
            UpdateItems(newCv.Achievements);
            UpdateItems(newCv.References);
            UpdateItems(newCv.WorkExperiences);
            UpdateItems(newCv.Conferences);

            _context.SaveChanges();
            return newCv;
        }

        private void UpdateItems<T>(IEnumerable<T> items) where T : class
        {
            foreach (var item in items)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
        }

        public void CreateNewCv()
        {
            var generator = new CvGenerator();
            _context.Cvs.Add(generator.GetElizabethsCv());
            _context.SaveChanges();
        }
    }
}
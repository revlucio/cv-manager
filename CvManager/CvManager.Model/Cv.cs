using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace CvManager.Model
{
    public class Cv
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Education> Educations { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }

        [UIHint("tinymce_basic_tall"), AllowHtml]
        public string Fieldwork { get; set; }

        [UIHint("tinymce_basic_tall"), AllowHtml]
        public string Skills { get; set; }

        public List<Conference> Conferences { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Reference> References { get; set; }

        public bool IsLive { get; set; }
        public DateTime LastModifiedDateTime { get; set; }

        public Cv()
        {
            Educations = new List<Education>();
            Conferences = new List<Conference>();
            WorkExperiences = new List<WorkExperience>();
            Achievements = new List<Achievement>();
            References = new List<Reference>();
            Fieldwork = String.Empty;
            Skills = String.Empty;
        }

        public List<Education> GetOrderedEducations()
        {
            return Educations.OrderByDescending(e => e.ConvertEndTime()).ToList();
        }
    }
}
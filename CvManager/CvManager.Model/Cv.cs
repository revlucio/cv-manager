using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
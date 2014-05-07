using System.Collections.Generic;

namespace CvManager.Model
{
    public class Cv
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Education> Educations { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public string Fieldwork { get; set; }
        public List<string> Conferences { get; set; }
        public List<string> Achievements { get; set; }
        public string Skills { get; set; }
        public List<Reference> References { get; set; } 
    }
}
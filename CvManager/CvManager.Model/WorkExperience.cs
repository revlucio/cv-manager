using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CvManager.Model
{
    public class WorkExperience : CvSection
    {
        public string Company { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string JobTitle { get; set; }

        [UIHint("tinymce_basic"), AllowHtml]
        public string Details { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;

namespace CvManager.Model
{
    public class Education
    {
        public int Id { get; set; }

        public string Degree { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Institute { get; set; }

        [UIHint("tinymce_basic"), AllowHtml]
        public string Details { get; set; }

        public DateTime ConvertEndTime()
        {
            DateTime endDate;
            var parsed = DateTime.TryParse(EndDate, null, DateTimeStyles.None, out endDate);

            return parsed ? endDate : DateTime.MinValue;
        }
    }
}
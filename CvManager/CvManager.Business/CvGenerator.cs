using CvManager.Model;
using System.Collections.Generic;

namespace CvManager.Business
{
    public class CvGenerator
    {
        public Cv GetElizabethsCv()
        {
            return new Cv
            {
                FullName = "Elizabeth L. Knox",
                Email = "elizabeth@elknox.com",
                Website = "www.elknox.com",
                PhoneNumber = "07745930645",
                Address = "London, UK",
                Educations = GetEducationList(),
                WorkExperiences = GetWorkExperiencList(),
             };
        }

        private List<Education> GetEducationList()
        {
            return new List<Education>
            {
                new Education
                {
                    Degree = "MSc Forensic Archaeology",
                    StartDate = "Aug 2012",
                    EndDate = "Oct 2013",
                    Institute = "Bournemouth University (BU)",
                    Details =
                        "Dissertation: “Detecting the Dead: An analysis of current geophysical surveying techniques in locating and identifying mass graves.”",
                },
                new Education
                {
                    Degree = "1st Class Combined Honours in Archaeology and Biological Anthropology",
                    StartDate = "Jan 2010",
                    EndDate = "Nov 2010",
                    Institute = "Australian National University (ANU)",
                    Details =
                        "Thesis: “The Bone Puzzle: A Skeletal &amp; Taphonomic Analysis of Fragmentary human remains from Callao Cave Northern Luzon.”",
                },
                new Education
                {
                    Degree = "Bachelor of Arts",
                    StartDate = "Feb 2005",
                    EndDate = "Nov 2009",
                    Institute = "Australian National University (ANU)",
                    Details = "Three Majors: Archaeology, Biological Anthropology and Art History (Curatorship)",
                },
                new Education
                {
                    Degree = "Bachelor of Arts (Visual)",
                    StartDate = "Feb 2004",
                    EndDate = "Oct 2004",
                    Institute = "Australian National University (ANU)",
                    Details = "Major: Painting<em> Transferred with status to a BA</em>",
                },
            };
        }

        private List<WorkExperience> GetWorkExperiencList()
        {
            return new List<WorkExperience>();
        }
    }
}

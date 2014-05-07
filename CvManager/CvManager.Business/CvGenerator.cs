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
                Fieldwork = GetFieldwork(),
                Conferences = GetConferences(),
                Achievements = GetAchievements(),
                References = GetReferences(),
                Skills = GetSkills(),
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
            return new List<WorkExperience>
            {
                new WorkExperience
                {
                    Company = "National Museum of Australia (NMA)",
                    StartDate = "Jan 2009",
                    EndDate = "Oct 2013",
                    JobTitle = "On-going NMA Visitors Service Host",
                    Details = "Tour guide, front of house, reception, administration, fire warden and driver.&nbsp;<em>(I owned this position throughout my employment at the NMA although I was on temporary contracts in other areas until Aug 2012 when I went to the UK on study leave and&nbsp;subsequently resigned in 2013).</em>"
                },
                new WorkExperience
                {
                    Company = "National Museum of Australia",
                    StartDate = "Nov 2011",
                    EndDate = "Aug 2012",
                    JobTitle = "Assistant Curator",
                    Details = "Aboriginal and Torres Strait Islander Program (ATSIP) &amp;&nbsp;People and the Environment (PATE):<br>Developing content and working with the NMA collection to refresh the Permanent Gallery Old New Land and curating the Diana Boyer exhibition.&nbsp;Assisting with the curatorial responsibilities associated with Inside: Life in Children’s Homes and Institutions. Including contacting and recording stakeholders stories, inquiring about objects and the histories behind them, data entry and admin.&nbsp;<br><br>"
                },
                new WorkExperience
                {
                    Company = "National Museum of Australia",
                    StartDate = "Aug 2010",
                    EndDate = "Nov 2011",
                    JobTitle = "Exhibitions Officer / Exhibitions Support Officer",
                    Details = "Project management of permanent galleries and travelling&nbsp;exhibitions at the NMA. Liaising with contractors and internal staff, to provide effective problem solving and results.&nbsp; Project manager and OH&amp;S enforcer for the Torres Strait Islander Gallery redevelopment “Bipotaim”.&nbsp;Administrative support for the Exhibitions and Gallery Development team. Part of the project management team for the large gallery development of “Landmarks”, responsible for budgets, schedules, RFQ's, transportation and meeting chair and writing minutes and reports.&nbsp;<br>"
                },
                new WorkExperience
                {
                    Company = "National Dinosaur Museum",
                    StartDate = "Aug 2007",
                    EndDate = "Jan 2009",
                    JobTitle = "Tour Guide",
                    Details = "School tours, Pubic tours, Party Host, Dinosaurs at School, Reception, Retail, and illustrator"
                },
            };
        }

        private string GetFieldwork()
        {
            return @"BU International Student promotional video (Aug 13)<br><br>
                    BU Mass grave simulation (June 13)<br>Role: Archaeology excavator, Supervisor, Student ambassador<br>
                    <a href='http://www.youtube.com/watch?v=Zh54LTe3Fd0' rel='nofollow'>http://www.youtube.com/watch?v=Zh54LTe3Fd0</a>
                    <br><br>
                    BU Plane crash simulation with Blake’s Emergency Services (Feb 13)<br>Role: Body and Evidence recovery<br><br>
                    Catanauan Archaeology &amp; Heritage Project Session 3 and 4 (Jan – Feb 11/12)<br>Role: Supervisor, Archaeologist, Lead Cartographer.&nbsp;<br><br>
                    OH&amp;S Construction Site Induction course: (Apr- 11)<br>Completed: &nbsp;White card training in the ACT, acknowledged across Australia.&nbsp;<br><br>
                    Catanauan Archaeological &amp; Heritage Project Session 2: (Jan – Feb 10)<br>Role: Supervisor, Archaeology student.<br><br>
                    Prime Possum Breakfast Club TV Show: (Aired on Network television Dec 09)<br>Role: Guest speaker and Spokesperson for the NMA, on the Temporary Exhibit “Water: H2O=life''.<br><br>
                    ANU Forensic Archaeology &amp; Anthropology mock excavation: (Sept 09)<br>Role: Supervisor.&nbsp;<br><br>
                    Mogo Zoo: mini Excavation: (Jul 09)<br>Role: Mammalian remains retrieval, sorting, and cleaning.&nbsp;With: Dr. Colin Groves (ANU).&nbsp;<br><br>
                    Pacific Research centre ANU. Work experience: (Apr 09)<br>Identification / classification of remains. Teouma site Vanuatu.&nbsp;With: Dr. Frédérique Valentin (University of Paris &amp; CNRS)<br><br>
                    Catanauan, Philippines Field School, ANU &amp; UP (Session 1): (Nov – Dec 08)<br>Excavation,set up, archaeological recording and retrieval.&nbsp;With: Dr. Marc Oxenham (ANU ) &amp; Prof. Victor Paz (UP)<br><br>";
        }

        private string GetSkills()
        {
            return @"<strong>Computer Skills:</strong>
                    <br>Microsoft Word, Excel, Power point, and Publisher, ArcGIS, Ground vision, and Easy3D, Adobe Illustrator, Paint, Internet savvy, Outlook, Groupwise, and Gmail.<br><br>
                    <strong>Full Drivers License: <br>
                    </strong>Current Australian drivers license (car 12 people max) <br>International Permit (UK inclusive) <br><br>
                    <strong>Construction Induction Card:</strong>
                    <br>Australian White Card ACT. <br><br>
                    <strong>Language:</strong>
                    <br>English<br><br>";
        }

        private List<Conference> GetConferences()
        {
            return new List<Conference>
            {
                new Conference { Name = "Forensic Investigations to Locate and Identify the Missing Forum (London, 2014)" },
                new Conference { Name = "2nd Annual Forum for Mass Grave Victim Identification (London, 2013)" },
                new Conference { Name = "Crime Scene and Disaster Victim Identification Forum (London, 2013)" },
                new Conference { Name = "Australasian Society of Human Biology (ASHB) Canberra Conference (Canberra, 2011)" },
                new Conference { Name = "7th Katipunan Arkeologist ng Pilipinas (KAPI) Conference (Manila, 2008)" },
            };
        }

        private List<Achievement> GetAchievements()
        {
            return new List<Achievement>
            {
                new Achievement { Name = "Kenyon International Emergency Services: Team Member (2013)" },
                new Achievement { Name = "Institute for Archaeologists (IFA): member 7774 (2013)" },
                new Achievement { Name = "Australian Archaeology Association (AAA): member (2012)" },
                new Achievement { Name = "Australasian society for Human Biology (ASHB): member (2012)" },
                new Achievement { Name = "Rainbow Volunteer, ACT Mental Health Foundation Volunteer (08/09)" },
                new Achievement { Name = "SharpFX Certificate in Prosthetic Special Effects (08)" },
                new Achievement { Name = "The Dinosaur Age: Issue 11: Illustration: Fin evolution diagram (08)" },
                new Achievement { Name = "ANU Student Association general representative (06)" },
                new Achievement { Name = "ANU Burgmann College Arts and Social representative (05)" },
                new Achievement { Name = "ANU Arts and Social Inter-hall committee secretary (05)" },
                new Achievement { Name = "Manly Gallery and Museum's Inaugural Theo Batten Youth Art Award (04)" },
                new Achievement { Name = "Express Yourself Art Exhibition at the Manly Gallery and Museum (04)" },
            };
        }

        private List<Reference> GetReferences()
        {
            return new List<Reference>
            {
                new Reference
                {
                    FullName = "Paul Cheetham",
                    Job = "Bournemouth University",
                    PhoneNumber = "+44 1202 961409",
                    Email = "pcheetham@bournemouth.ac.uk"
                },
                new Reference
                {
                    FullName = "Dr Martha Sear",
                    Job = "National Museum of Australia",
                    PhoneNumber = "+61 2 6208 5000",
                    Email = "martha.sear@nma.gov.au"
                },
                new Reference
                {
                    FullName = "Dr Marc Oxenham",
                    Job = "Australian National University",
                    PhoneNumber = "+61 2 6125 4418",
                    Email = "marc.oxenham@anu.edu.au"
                },
                new Reference
                {
                    FullName = "Dr Victor Paz",
                    Job = "University of the Philippines, Diliman",
                    PhoneNumber = "+63 29241836",
                    Email = "victor.paz@up.edu.ph"
                },
            };
        }
    }
}

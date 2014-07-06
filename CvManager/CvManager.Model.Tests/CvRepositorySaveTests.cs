using NUnit.Framework;
using System;
using System.Linq;

namespace CvManager.Model.Tests
{
    [TestFixture]
    public class CvRepositorySaveTests
    {
        private CvRepository _repository;
        private Cv _cv;

        [SetUp]
        public void BeforeEachTest()
        {
            _repository = new CvRepository();
            _cv = new Cv();

            var cv = _repository.GetElizabethsCv();
            _cv.Id = cv.Id;
            _cv.Educations = cv.Educations;
            _cv.Achievements = cv.Achievements;
        }

        private Cv GetUpdatedCv()
        {
            var repo = new CvRepository();
            repo.SaveNewCv(_cv);
            return repo.GetElizabethsCv();
        }

        [Test]
        public void SaveNewCv_UpdatesEmail()
        {
            var email = "test@test.com" + DateTime.Now.Ticks;
            _cv.Email = email;

            var result = GetUpdatedCv();

            Assert.That(result.Email, Is.EqualTo(email));
        }

        [Test]
        public void SaveNewCv_UpdatesEducation()
        {
            var degree = "test" + DateTime.Now.Ticks;
            _cv.Educations[0].Degree = degree;

            var result = GetUpdatedCv();

            Assert.That(result.Educations[0].Degree, Is.EqualTo(degree));
        }

        [Test]
        public void SaveNewCv_RemovesEducation()
        {
            var num = _cv.Educations.Count;
            _cv.Educations.RemoveAt(0);

            var result = GetUpdatedCv();

            Assert.That(result.Educations.Count, Is.EqualTo(num-1));
        }

        [Test]
        public void SaveNewCv_AddEducation()
        {
            var degree = GetUniqueString();
            _cv.Educations.Add(new Education{Degree = degree});

            var result = GetUpdatedCv();

            Assert.That(result.Educations.SingleOrDefault(e => e.Degree == degree), Is.Not.Null);
        }

        [Test]
        public void SaveNewCv_AddConference()
        {
            var placeholder = GetUniqueString();
            _cv.Conferences.Add(new Conference {Name = placeholder});

            var result = GetUpdatedCv();

            Assert.That(result.Conferences.SingleOrDefault(e => e.Name == placeholder), Is.Not.Null);
        }

        [Test]
        public void SaveNewCv_AddAchievment()
        {
            var placeholder = GetUniqueString();
            _cv.Achievements.Add(new Achievement { Name = placeholder });

            var result = GetUpdatedCv();

            Assert.That(result.Achievements.SingleOrDefault(e => e.Name == placeholder), Is.Not.Null);
        }

        [Test]
        public void SaveNewCv_AddWorkExperience()
        {
            var placeholder = GetUniqueString();
            _cv.WorkExperiences.Add(new WorkExperience { Company = placeholder });

            var result = GetUpdatedCv();

            Assert.That(result.WorkExperiences.SingleOrDefault(e => e.Company == placeholder), Is.Not.Null);
        }

        [Test]
        public void SaveNewCv_AddReference()
        {
            var placeholder = GetUniqueString();
            _cv.References.Add(new Reference { FullName = placeholder});

            var result = GetUpdatedCv();

            Assert.That(result.References.SingleOrDefault(e => e.FullName == placeholder), Is.Not.Null);
        }

        [Test]
        public void SaveNewCv_UpdatesAchievement()
        {
            var placeholder = GetUniqueString();
            _cv.Achievements[0].Name = placeholder;

            var result = GetUpdatedCv();

            Assert.That(result.Achievements[0].Name, Is.EqualTo(placeholder));
        }

        private string GetUniqueString()
        {
            return "test" + DateTime.Now.Ticks;
        }
    }
}

using NUnit.Framework;

namespace CvManager.Model.Tests
{
    [TestFixture]
    [Ignore]
    public class CvRepositoryIntegrationTests
    {
        private CvRepository _repository;
        private Cv _cv;

        [SetUp]
        public void BeforeEachTest()
        {
            _repository = new CvRepository();
            _cv = _repository.GetElizabethsCv();
        }

        [Test]
        public void AddCv()
        {
            //_repository.CreateNewCv();
        }

        [Test]
        public void GetElizabethsCv_ReturnsCv()
        {
            Assert.That(_cv, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasEducations()
        {
            Assert.That(_cv.Educations, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasConferences()
        {
            Assert.That(_cv.Conferences, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasAchievements()
        {
            Assert.That(_cv.Achievements, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasReferences()
        {
            Assert.That(_cv.References, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasWorkExperiences()
        {
            Assert.That(_cv.WorkExperiences, Is.Not.Null);
        }
    }
}

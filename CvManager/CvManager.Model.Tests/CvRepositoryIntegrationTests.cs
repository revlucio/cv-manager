using NUnit.Framework;

namespace CvManager.Model.Tests
{
    [TestFixture]
    [Ignore]
    public class CvRepositoryIntegrationTests
    {
        [Test]
        public void AddCv()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            repository.CreateNewCv();
        }

        [Test]
        public void GetElizabethsCv_ReturnsCv()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasEducations()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv.Educations, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasConferences()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv.Conferences, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasAchievements()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv.Achievements, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasReferences()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv.References, Is.Not.Null);
        }

        [Test]
        public void GetElizabethsCv_HasWorkExperiences()
        {
            // ARRANGE
            var repository = new CvRepository();

            // ACT
            var cv = repository.GetElizabethsCv();

            // ASSERT
            Assert.That(cv.WorkExperiences, Is.Not.Null);
        }
    }
}

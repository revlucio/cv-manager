using NUnit.Framework;

namespace CvManager.Model.Tests
{
    [TestFixture]
    public class CvRepository_Tests
    {
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
    }
}

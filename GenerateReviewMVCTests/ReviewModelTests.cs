using NUnit.Framework;
using GenerateReviewMVC.Models;

namespace GenerateReviewMVCTests
{
    public class ModelTests
    {
        [Test]
        public void CreateReviewModelTest()
        {
            Review review = new Review();
            Assert.That(review, Is.Not.Null);
        }

        [Test]
        public void CreateReviewModelAndSetPropertiesTest()
        {
            Review review = new Review
            {
                Name = "Super Mario Cart",
                Summary = "Great Game",
                StarRating = 5
            };

            Assert.That(review, Is.Not.Null);
            Assert.AreEqual(review.Name, "Super Mario Cart");
            Assert.AreEqual(review.Summary, "Great Game");
            Assert.AreEqual(review.StarRating, 5);
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using GenerateReviewMVC.Controllers;
using GenerateReviewMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Moq;

namespace GenerateReviewMVCTests
{
    public class ReviewControllerTests
    {
        ILogger<HomeController> _logger;
        IWebHostEnvironment _hostingEnvironment;
        HomeController _homeController;

        [SetUp]
        public void Setup()
        {
            _logger = Mock.Of<ILogger<HomeController>>();
            _hostingEnvironment = Mock.Of<IWebHostEnvironment>();
            _hostingEnvironment.WebRootPath = Directory.GetCurrentDirectory();
            _homeController = new HomeController(_logger, _hostingEnvironment);
        }

        [Test]
        public void CreateNewHomeControllerTest()
        {
            Assert.That(_homeController, Is.Not.Null);
        }

        [Test]
        public void HomeControllerViewNameEqualsIndexTest()
        {
            ViewResult result = _homeController.Generate("Super Mario Cart") as ViewResult;
            Assert.That(result.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void HomeControllerReturnsReviewObject()
        {
            ViewResult result = _homeController.Generate("Super Mario Cart") as ViewResult;
            var model = result.ViewData.Model;
            Assert.IsInstanceOf<Review>(model);
        }
    }
}

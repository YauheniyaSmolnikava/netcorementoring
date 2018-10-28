using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NetCoreTestApp.Controllers;
using NetCoreTestApp.Models;
using Xunit;

namespace NetCoreTestApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsAViewResult()
        {
            var controller = GetController();

            var result = controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void About_ReturnsAViewResult_WithFilledMessage()
        {
            var controller = GetController();

            var result = controller.About();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.ViewData["Message"]);
        }

        [Fact]
        public void Contact_ReturnsAViewResult_WithFilledMessage()
        {
            var controller = GetController();

            var result = controller.Contact();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.ViewData["Message"]);
        }

        [Fact]
        public void Privacy_ReturnsAViewResult()
        {
            var controller = GetController();

            var result = controller.Privacy();
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Error_ReturnsAViewResult_With_ErrorViewModel()
        {
            var controller = GetController();
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            var result = controller.Error();
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<ErrorViewModel>(viewResult.ViewData.Model);
            Assert.Equal("Unexpected Error", model.Message);
        }

        private HomeController GetController()
        {
            var logger = new Mock<ILogger<HomeController>>();

            return new HomeController(logger.Object);
        }
    }
}

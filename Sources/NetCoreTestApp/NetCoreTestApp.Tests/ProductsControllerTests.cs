using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using NetCoreTestApp.Models;

namespace NetCoreTestApp.Tests
{
    public class ProductsControllerTests
    {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfSelectedProducts()
        {
            //var mockRepo = new Mock<NorthwindContext>();
            //mockRepo.Setup(repo => repo.Products)
            //    .ReturnsAsync(GetTestSessions());
            //var controller = new HomeController(mockRepo.Object)
        }

    }
}

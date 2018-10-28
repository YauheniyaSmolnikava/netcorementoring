using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Moq;
using NetCoreTestApp.Models;
using NetCoreTestApp.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Logging;
using NetCoreTestApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreTestApp.Tests
{
    public class ProductsControllerTests
    {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfSelectedProducts()
        {
            var productsCount = 5;
        
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.GetProducts(productsCount)).ReturnsAsync(GetTestProducts(productsCount));

            var controller = GetController(mockRepo);

            var result = await controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<List<Products>>(viewResult.ViewData.Model);
            Assert.Equal(productsCount, model.Count);
        }

        [Fact]
        public async Task Details_ReturnsAViewResult_WithProductsDetails()
        {
            var productId = 1;
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.GetDetails(productId)).ReturnsAsync(GetTestProductDetails(productId));

            var controller = GetController(mockRepo);

            var result = await controller.Details(productId);
            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
            Assert.Equal(productId, model.ProductId);
        }

        [Fact]
        public async Task Create_ReturnsARedirectActionResult_IndexPage()
        {
            var products = GetTestProductDetails(1);
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.Create(products)).ReturnsAsync(1);

            var controller = GetController(mockRepo);

            var result = await controller.Create(products);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName); 
        }

        [Fact]
        public async Task Edit_ReturnsNotFound_WithIdNull()
        {
            var products = GetTestProductDetails(1);
            var mockRepo = new Mock<IProductsRepository>();

            var controller = GetController(mockRepo);

            var result = await controller.Edit(null);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Edit_ReturnsAViewResult_WithSelectedProduct()
        {
            var productId = 1;
            var products = GetTestProductDetails(1);
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(GetTestProductDetails(productId));

            var controller = GetController(mockRepo);

            var result = await controller.Edit(productId);
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
            Assert.Equal(productId, model.ProductId);
        }

        [Fact]
        public async Task Edit_ReturnsARedirectActionResult_IndexPage()
        {
            var productId = 1;
            var products = GetTestProductDetails(productId);
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.Update(products)).ReturnsAsync(1);
            mockRepo.Setup(repo => repo.ProductsExists(productId)).Returns(true);

            var controller = GetController(mockRepo);

            var result = await controller.Edit(productId, products);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        [Fact]
        public async Task Delete_ReturnsAViewResult_WithSelectedProduct()
        {
            var productId = 1;
            var products = GetTestProductDetails(1);
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.GetDetails(productId)).ReturnsAsync(GetTestProductDetails(productId));

            var controller = GetController(mockRepo);

            var result = await controller.Delete(productId);
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
            Assert.Equal(productId, model.ProductId);
        }

        [Fact]
        public async Task DeleteConfirmed_ReturnsARedirectActionResult_IndexPage()
        {
            var productId = 1;
            var mockRepo = new Mock<IProductsRepository>();
            mockRepo.Setup(repo => repo.DeleteAsync(productId)).ReturnsAsync(1);

            var controller = GetController(mockRepo);

            var result = await controller.DeleteConfirmed(productId);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        private List<Products> GetTestProducts(int top)
        {
            var productsList = new List<Products>();

            for (var i = 0; i < top; i++)
            {
                productsList.Add(GetTestProductDetails(i));
            }

            return productsList;
        }

        private Products GetTestProductDetails(int id)
        {
            return new Products
            {
                ProductId = id,
                ProductName = $"Test Product Name - {id}"
            };
        }

        private ProductsController GetController(Mock<IProductsRepository> mockRespository)
        {
            var config = new Mock<IConfiguration>();
            config.Setup(c => c.GetSection("QueryParams")).Returns(new TestConfigSection());

            var logger = new Mock<ILogger<ProductsController>>();

            return new ProductsController(mockRespository.Object, config.Object, logger.Object);
        }

    }

    public class TestConfigSection : IConfigurationSection
    {
        private string productsCount = "5";

        public string this[string key] { get => productsCount; set => throw new System.NotImplementedException(); }

        public string Key => productsCount;

        public string Path => productsCount;

        public string Value { get => "5"; set => throw new System.NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new System.NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new System.NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            return this;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Moq;
using NetCoreTestApp.Controllers;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NetCoreTestApp.Tests
{
    public class CategoriesControllerTests
    {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfAllCategories()
        {
            var categoriesCount = 5;
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(GetTestCatgories(categoriesCount));

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<List<Categories>>(viewResult.ViewData.Model);
            Assert.Equal(categoriesCount, model.Count);
        }

        [Fact]
        public async Task Details_ReturnsAViewResult_WithCategoryDetails()
        {
            var categoryId = 1;
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.GetDetails(categoryId)).ReturnsAsync(GetTestCategoryDetails(categoryId));

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Details(categoryId);
            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<Categories>(viewResult.ViewData.Model);
            Assert.Equal(categoryId, model.CategoryId);
        }

        [Fact]
        public async Task Create_ReturnsARedirectActionResult_IndexPage()
        {
            var categories = GetTestCategoryDetails(1);
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.Create(categories)).ReturnsAsync(1);

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Create(categories);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        [Fact]
        public async Task Edit_ReturnsNotFound_WithIdNull()
        {
            var categories = GetTestCategoryDetails(1);
            var mockRepo = new Mock<ICategoriesRepository>();

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Edit(null);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Edit_ReturnsAViewResult_WithSelectedCategory()
        {
            var categoryId = 1;
            var products = GetTestCategoryDetails(1);
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.GetById(categoryId)).ReturnsAsync(GetTestCategoryDetails(categoryId));

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Edit(categoryId);
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Categories>(viewResult.ViewData.Model);
            Assert.Equal(categoryId, model.CategoryId);
        }

        [Fact]
        public async Task Edit_ReturnsARedirectActionResult_IndexPage()
        {
            var categoryId = 1;
            var categories = GetTestCategoryDetails(categoryId);
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.Update(categories)).ReturnsAsync(1);
            mockRepo.Setup(repo => repo.CategoriesExists(categoryId)).Returns(true);

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Edit(categoryId, categories);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        [Fact]
        public async Task Delete_ReturnsAViewResult_WithSelectedCategory()
        {
            var categoryId = 1;
            var categories = GetTestCategoryDetails(1);
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.GetById(categoryId)).ReturnsAsync(GetTestCategoryDetails(categoryId));

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.Delete(categoryId);
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Categories>(viewResult.ViewData.Model);
            Assert.Equal(categoryId, model.CategoryId);
        }

        [Fact]
        public async Task DeleteConfirmed_ReturnsARedirectActionResult_IndexPage()
        {
            var categoryId = 1;
            var mockRepo = new Mock<ICategoriesRepository>();
            mockRepo.Setup(repo => repo.Delete(categoryId)).ReturnsAsync(1);

            var controller = new CategoriesController(mockRepo.Object);

            var result = await controller.DeleteConfirmed(categoryId);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);

            Assert.Equal("Index", redirectResult.ActionName);
        }

        private List<Categories> GetTestCatgories(int top)
        {
            var categoriesList = new List<Categories>();

            for (var i = 0; i < top; i++)
            {
                categoriesList.Add(GetTestCategoryDetails(i));
            }

            return categoriesList;
        }

        private Categories GetTestCategoryDetails(int id)
        {
            return new Categories
            {
                CategoryId = id,
                CategoryName = $"Test Product Name - {id}"
            };
        }

    }
}

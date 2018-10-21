using Microsoft.EntityFrameworkCore;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTestApp.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly NorthwindContext _context;

        public CategoriesRepository(NorthwindContext context)
        {
            _context = context;
        }

        public bool CategoriesExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }

        public Task<int> Create(Categories categories)
        {
            _context.Add(categories);
            return _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            var categories = await _context.Categories.FindAsync(id);
            var productsList = _context.Products.Where(p => p.CategoryId == categories.CategoryId);

            foreach (var products in productsList)
            {
                var orderDetails = _context.OrderDetails.Where(od => od.ProductId == products.ProductId);
                _context.OrderDetails.RemoveRange(orderDetails);
            }

            _context.Products.RemoveRange(productsList);
            _context.Categories.Remove(categories);
            return await _context.SaveChangesAsync();
        }

        public Task<List<Categories>> GetAll()
        {
            return _context.Categories.ToListAsync();
        }

        public Task<Categories> GetById(int id)
        {
            return _context.Categories.FindAsync(id);
        }

        public Task<Categories> GetDetails(int id)
        {
            return _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
        }

        public Task<int> Update(Categories categories)
        {
            _context.Update(categories);
            return _context.SaveChangesAsync();
        }
    }
}

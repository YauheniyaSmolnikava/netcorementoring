using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTestApp.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly NorthwindContext _context;

        public ProductsRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Task<int> Create(Products products)
        {
            _context.Add(products);
            return  _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var products = await _context.Products.FindAsync(id);
            var orderDetails = _context.OrderDetails.Where(od=>od.ProductId == products.ProductId);
            _context.OrderDetails.RemoveRange(orderDetails);
            _context.Products.Remove(products);
            return await _context.SaveChangesAsync();
        }

        public Task<Products> GetById(int id)
        {
            return _context.Products.FindAsync(id);
        }

        public SelectList GetCategoriesList()
        {
            return new SelectList(_context.Categories, "CategoryId", "CategoryName");
        }

        public async Task<Products> GetDetails(int id)
        {
            return  await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.ProductId == id);
        }

        public IQueryable<Products> GetProducts(int top)
        {
            var products = _context.Products.Include(p => p.Category).Include(p => p.Supplier);
            return products.Take(top > 0 ? top : products.Count());
        }

        public SelectList GetSuppliersList()
        {
            return new SelectList(_context.Suppliers, "SupplierId", "CompanyName");
        }

        public bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        public Task<int> Update(Products products)
        {
            _context.Update(products);
            return _context.SaveChangesAsync();
        }
    }
}

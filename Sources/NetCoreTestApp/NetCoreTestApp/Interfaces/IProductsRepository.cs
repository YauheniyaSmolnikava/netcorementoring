using Microsoft.AspNetCore.Mvc.Rendering;
using NetCoreTestApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTestApp.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Products>> GetProducts(int top);
        Task<Products> GetDetails(int id);
        Task<int> Create(Products products);
        Task<Products> GetById(int id);
        Task<int> Update(Products products);
        Task<int> DeleteAsync(int id);

        bool ProductsExists(int id);

        SelectList GetCategoriesList();
        SelectList GetSuppliersList();
    }
}

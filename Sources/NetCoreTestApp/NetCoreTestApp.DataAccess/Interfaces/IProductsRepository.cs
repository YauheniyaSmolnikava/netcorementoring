using NetCoreTestApp.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreTestApp.DataAccess.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Products>> GetProducts(int top);
        Task<List<Products>> GetAll();
        Task<Products> GetDetails(int id);
        Task<int> Create(Products products);
        Task<Products> GetById(int id);
        Task<int> Update(Products products);
        Task<int> DeleteAsync(int id);

        bool ProductsExists(int id);

        Task<List<Categories>> GetCategoriesList();
        Task<List<Suppliers>> GetSuppliersList();
    }
}

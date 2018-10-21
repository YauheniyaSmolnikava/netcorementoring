using NetCoreTestApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreTestApp.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> GetAll();

        Task<Categories> GetDetails(int id);

        Task<int> Create(Categories categories);

        Task<Categories> GetById(int id);

        Task<int> Update(Categories categories);

        Task<int> Delete(int id);

        bool CategoriesExists(int id);
    }
}

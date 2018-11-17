using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreTestApp.DataAccess.Interfaces;
using NetCoreTestApp.DataAccess.Models;

namespace NetCoreTestApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> Get()
        {
            return await _categoriesRepository.GetAll();
        }
    }
}
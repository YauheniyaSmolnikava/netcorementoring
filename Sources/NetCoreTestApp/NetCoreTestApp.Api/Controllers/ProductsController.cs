using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreTestApp.DataAccess.Interfaces;
using NetCoreTestApp.DataAccess.Models;

namespace NetCoreTestApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> Get()
        {
            return await _productsRepository.GetAll();
        }
    }
}
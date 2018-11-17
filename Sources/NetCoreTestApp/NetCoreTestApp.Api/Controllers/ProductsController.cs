using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpPost]
        public async void Post([FromBody] Products product)
        {
            await _productsRepository.Create(product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Products product)
        {
            try
            {
                await _productsRepository.Update(product);
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_productsRepository.ProductsExists(product.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _productsRepository.DeleteAsync(id);
        }
    }
}
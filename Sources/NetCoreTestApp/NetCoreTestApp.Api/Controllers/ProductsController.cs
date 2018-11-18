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

        /// <summary>
        /// This method returns all available products
        /// </summary>
        /// <returns>list of products</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> Get()
        {
            return await _productsRepository.GetAll();
        }

        /// <summary>
        /// This method allows to create new product based on passed param
        /// </summary>
        /// <param name="product">Filled product object</param>
        [HttpPost]
        public async void Post([FromBody] Products product)
        {
            await _productsRepository.Create(product);
        }

        /// <summary>
        /// This method allows to update existing product
        /// </summary>
        /// <param name="id">id of existing product</param>
        /// <param name="product">product with updated data</param>
        /// <returns></returns>
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

        /// <summary>
        /// This method allows to delete exisiting product
        /// </summary>
        /// <param name="id">identifier of product that need to be deleted</param>
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _productsRepository.DeleteAsync(id);
        }
    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Models;

namespace NetCoreTestApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private int _topProductsCount;
        private readonly ILogger<ProductsController> _logger;
        private readonly IConfiguration _configuration;

        public ProductsController(IProductsRepository productsRepository, IConfiguration configuration, ILogger<ProductsController> logger)
        {
            _productsRepository = productsRepository;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            _topProductsCount = _configuration.GetSection("QueryParams").GetValue<int>("TopProductsCount");

            _logger.LogInformation($"Configuration param has been retrived: Top Products Count: {_topProductsCount}");

            var selectedProducts = _productsRepository.GetProducts(_topProductsCount);
            return View(await selectedProducts.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _productsRepository.GetDetails(id.Value);

            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = _productsRepository.GetCategoriesList();
            ViewData["SupplierId"] = _productsRepository.GetSuppliersList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,SupplierId,CategoryId,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued")] Products products)
        {
            if (ModelState.IsValid)
            {
                await _productsRepository.Create(products);
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = _productsRepository.GetCategoriesList();
            ViewData["SupplierId"] = _productsRepository.GetSuppliersList();

            return View(products);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _productsRepository.GetById(id.Value);

            if (products == null)
            {
                return NotFound();
            }

            ViewData["CategoryId"] = _productsRepository.GetCategoriesList();
            ViewData["SupplierId"] = _productsRepository.GetSuppliersList();

            return View(products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,SupplierId,CategoryId,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued")] Products products)
        {
            if (id != products.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productsRepository.Update(products);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_productsRepository.ProductsExists(products.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = _productsRepository.GetCategoriesList();
            ViewData["SupplierId"] = _productsRepository.GetSuppliersList();

            return View(products);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _productsRepository.GetDetails(id.Value);

            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productsRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

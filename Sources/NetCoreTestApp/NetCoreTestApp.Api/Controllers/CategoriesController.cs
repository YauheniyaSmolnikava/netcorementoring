using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("images/{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            var categories = await _categoriesRepository.GetById(id);

            if (categories != null && categories.Picture != null)
            {
                var image = categories.Picture.Skip(78).ToArray();

                return new FileContentResult(image, (new MediaTypeHeaderValue("image/bmp")).MediaType);
            }
            return NotFound();
        }

        [HttpPost("images/{id}")]
        public async Task<IActionResult> Upload(ImageUpload image)
        {
            if (image != null && image.File != null)
            {
                var filePath = Path.GetTempFileName();
                byte[] byteArray;

                if (image.File.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        image.File.CopyTo(stream);
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.File.CopyTo(ms);
                        byteArray = ms.ToArray();
                    }

                    var categories = await _categoriesRepository.GetById(image.CategoryId);
                    categories.Picture = (new byte[78]).Concat(byteArray).ToArray();

                    try
                    {
                        await _categoriesRepository.Update(categories);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_categoriesRepository.CategoriesExists(categories.CategoryId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }

            return Ok();
        }
    }
}
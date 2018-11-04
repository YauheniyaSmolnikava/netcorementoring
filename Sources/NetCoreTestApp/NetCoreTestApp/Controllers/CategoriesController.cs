using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Models;

namespace NetCoreTestApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoriesRepository.GetAll());
        }

        public async Task<IActionResult> GetImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoriesRepository.GetById(id.Value);

            var image = categories.Picture.Skip(78).ToArray();

            return new FileContentResult(image, (new MediaTypeHeaderValue("image/bmp")).MediaType);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoriesRepository.GetDetails(id.Value);

            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Upload(int id)
        {
            var model = new ImageUpload { CategoryId = id };
            return View(model);
        }

        [HttpPost]
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

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName,Description,Picture")] Categories categories)
        {
            if (ModelState.IsValid)
            {
                await _categoriesRepository.Create(categories);
                return RedirectToAction(nameof(Index));
            }
            return View(categories);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoriesRepository.GetById(id.Value);
            if (categories == null)
            {
                return NotFound();
            }
            return View(categories);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName,Description,Picture")] Categories categories)
        {
            if (id != categories.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                return RedirectToAction(nameof(Index));
            }
            return View(categories);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoriesRepository.GetById(id.Value);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _categoriesRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

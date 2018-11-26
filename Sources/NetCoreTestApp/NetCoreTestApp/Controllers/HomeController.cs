using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreTestApp.DataAccess.Models;
using NetCoreTestApp.Models;

namespace NetCoreTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var dateTimeNow = DateTime.Now;
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            if (exceptionFeature != null)
            {
                _logger.LogError($"[{dateTimeNow}] [{requestId}] Error occured: {exceptionFeature.Error.Message}. Exception path: {exceptionFeature.Path}");
            }

            return View(new ErrorViewModel { RequestId = requestId, Message = exceptionFeature != null ? exceptionFeature.Error.Message : "Unexpected Error", Time = dateTimeNow });
        }
    }
}

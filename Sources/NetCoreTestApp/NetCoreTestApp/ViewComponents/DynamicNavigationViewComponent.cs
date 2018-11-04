using Microsoft.AspNetCore.Mvc;
using NetCoreTestApp.ViewComponents.Models;
using System.Threading.Tasks;

namespace NetCoreTestApp.ViewComponents
{
    public class DynamicNavigationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string entityName, string formName = "")
        {
            var model = new DynamicNavigationModel
            {
                ControllerName = entityName,
                ActionName = formName
            };

            return View(model);
        }

    }
}

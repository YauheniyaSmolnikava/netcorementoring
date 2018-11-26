using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreTestApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministrationController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public AdministrationController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<IActionResult> Index()
        {
            var roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = _serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            
            string[] roleNames = { "Administrator", "User"};

            List<IdentityUser> users = new List<IdentityUser>();
            foreach (var roleName in roleNames)
            {

                var _user = await userManager.FindByEmailAsync("evgy.luts@gmail.com");

                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (roleExist)
                {
                    var usersInRole = await userManager.GetUsersInRoleAsync(roleName);
                    users.AddRange(usersInRole);
                }
            }

            return View(users);
        }
    }
}

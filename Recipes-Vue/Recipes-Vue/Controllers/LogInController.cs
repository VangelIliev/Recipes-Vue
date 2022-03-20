using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Models.AdminModels;
using System.Threading.Tasks;

namespace Recipes_Vue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly ILogger<LogInController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LogInController(
                ILogger<LogInController> logger,
                SignInManager<IdentityUser> signInManager,
                UserManager<IdentityUser> userManager)
        {
            this._logger = logger;
            this._signInManager = signInManager;
            this._userManager = userManager;
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(LogInUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email,
                           model.Password, model.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("All", "Recipes");
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return BadRequest(model);
        }
        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> LogOut()
        {
            await this._signInManager.SignOutAsync();
            return RedirectToAction("All", "Recipes");
        }
    }
}

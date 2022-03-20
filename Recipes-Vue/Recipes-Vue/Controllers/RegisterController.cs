using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recipes_Vue.Models.AdminModels;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterController(
        ILogger<RegisterController> logger,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager)
        {
            this._logger = logger;
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //await _emailSender.SendEmailAsync(model.Email, "Successfull registration", $"Hello {model.Email}, my name is Vangel and I am the owner of the website and I am glad that you registered. I wish you a pleasant time on the site");
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Ok(user);
                }
                var sb = new StringBuilder();
                foreach (var error in result.Errors)
                {
                    sb.AppendLine(error.Description);
                    sb.ToString().Trim();
                    ModelState.AddModelError("", error.Description);
                }
                return BadRequest(sb);
            }
            return BadRequest(model);
        }
    }
}

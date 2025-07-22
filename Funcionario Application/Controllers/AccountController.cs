using Funcionario_Application.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Funcionario_Application.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // mock

                if (vm.Email == "admin@example.com" && vm.Password == "senha123")
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "Admin"),
                        new Claim(ClaimTypes.Email, vm.Email),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true,
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("List", "Employee");
                }

                ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Settings()
        {
            var name = User.Identity?.Name ?? "Desconhecido";
            var email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value ?? "Não informado";

            var model = new
            {
                Name = name,
                Email = email
            };

            return View(model);
        }
    }
}

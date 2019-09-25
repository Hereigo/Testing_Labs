using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Cookie_Auth_CSRF.Models;
using Cookie_Auth_CSRF.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cookie_Auth_CSRF.Controllers
{
	public class AccountController : Controller
	{
		private readonly DatabaseContext _db;

		public AccountController(DatabaseContext context)
		{
			_db = context;
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginModel model)
		{
			if (ModelState.IsValid)
			{
				User user = await _db.Users
					.Include(u => u.Role)
					.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password)
					.ConfigureAwait(false);

				if (user != null)
				{
					await Authenticate(user).ConfigureAwait(false);

					return RedirectToAction("Index", "Home");
				}

				ModelState.AddModelError("", "Invalid login or password.");
			}
			return View(model);
		}

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).ConfigureAwait(false);

			return RedirectToAction("Login", "Account");
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterModel model)
		{
			if (ModelState.IsValid)
			{
				User user = await _db.Users.FirstOrDefaultAsync(u => u.Email == model.Email).ConfigureAwait(false);

				if (user == null)
				{
					user = new User { Email = model.Email, Password = model.Password, Age = model.Age };

					Role roleUsers = await _db.Roles.FirstOrDefaultAsync(r => r.Name == "Users").ConfigureAwait(false);

					if (roleUsers != null)
					{
						user.Role = roleUsers;
					}

					_db.Users.Add(user);

					await _db.SaveChangesAsync().ConfigureAwait(false);

					await Authenticate(user).ConfigureAwait(false);

					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Invalid login or password.");
				}
			}
			return View(model);
		}

		private async Task Authenticate(User user)
		{
			List<Claim> claims = new List<Claim>
			{
				new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
				new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
			};

			ClaimsIdentity id = new ClaimsIdentity(claims, "MyAppIdentityCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

			// SETUP AUTHENTIFICATION COOKIES :

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id)).ConfigureAwait(false);
		}
	}
}
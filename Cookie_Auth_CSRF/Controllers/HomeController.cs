using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Cookie_Auth_CSRF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cookie_Auth_CSRF.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Index()
		{
			string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;

			System.Security.Principal.IIdentity User_Identity = User.Identity;

			string myInfo = $" User = {User_Identity.Name}"
				+ $"+ Auth.type = {User_Identity.AuthenticationType}"
				+ $"+ User is in Role = {role}";

			foreach (Claim item in User.Claims)
			{
				myInfo += $"+ Claim.Issuer = {item.Issuer}";
				myInfo += $"+ Claim.Type = {item.Type}";
				myInfo += $"+ Claim.Value = {item.Value}";
				myInfo += $"+ Claim.ValueType = {item.ValueType}";
				myInfo += $"+ Claim.Subject = {item.Subject}";

				foreach (KeyValuePair<string, string> item2 in item.Properties)
				{
					myInfo += $"+ Claim.Property = {item2.Key} : {item2.Value}";
				}
			}

			ViewBag.UserIdentity = myInfo;

			return View();
		}

		[AllowAnonymous]
		public IActionResult Privacy()
		{
			return View();
		}
	}
}

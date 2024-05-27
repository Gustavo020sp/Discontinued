using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Linq.Expressions;

namespace SalesWebMvc.Controllers
{
	public class LoginController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Login(LoginUser loginUser)
		{
			try
			{

				if (ModelState.IsValid)
				{
					if (loginUser.Username == "adm@gmail" && loginUser.Password == "123")
					{
						return RedirectToAction("Index", "Home");
					}
					TempData["MensagemErro"] = $"Please verify: Username or Password incorret!";
				}
				return View("Index");
			}
			catch (Exception ex)
			{
				return View("Index");
			}

		}
	}
}

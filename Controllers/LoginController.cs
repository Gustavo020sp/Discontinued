using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
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
					return RedirectToAction("Index", "Home");
				}
				else
				{
                    return View("Index");
                }
				
			}
			catch (Exception ex)
			{
				return View("Index");	
			}

        }
    }
}

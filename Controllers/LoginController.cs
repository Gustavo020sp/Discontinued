using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

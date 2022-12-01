using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayerJqGrid.MVC.Controllers
{
	[Authorize(Roles = "Admin,Editor")]
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}


	}
}
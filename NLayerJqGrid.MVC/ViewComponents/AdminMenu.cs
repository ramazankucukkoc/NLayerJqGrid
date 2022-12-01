using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.MVC.Models;

namespace NLayerJqGrid.MVC.ViewComponents
{
	//[ViewComponent]
	public class AdminMenu : ViewComponent
	{
		private readonly UserManager<User> _userManager;

		public AdminMenu(UserManager<User> userManager)
		{
			_userManager = userManager;
		}

		public ViewViewComponentResult Invoke()
		{
			var user = _userManager.GetUserAsync(HttpContext.User).Result;
			var roles = _userManager.GetRolesAsync(user).Result;
			return View(new UserWithRolesViewModel
			{
				User = user,
				Roles = roles
			});

		}

	}
}

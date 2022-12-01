using NLayerJqGrid.Core.Entities.Concrete;

namespace NLayerJqGrid.MVC.Models
{
	public class UserWithRolesViewModel
	{
		public User User { get; set; }
		public IList<string> Roles { get; set; }
	}
}

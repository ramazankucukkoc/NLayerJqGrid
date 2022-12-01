
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace MVC.Model
{
	public class UserUpdateAjaxModel
	{
		public UserUpdateDto UserUpdateDto { get; set; }
		public User User { get; set; }
		public string UserUpdatePartial { get; set; }
	}
}

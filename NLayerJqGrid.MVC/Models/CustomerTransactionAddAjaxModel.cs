using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.MVC.Models
{
	public class CustomerTransactionAddAjaxModel
	{
		public CustomerTransactionForGetAllDto CustomerTransactionForGetAllDto { get; set; }

		public string CustomerTransactionAddPartial { get; set; }
	}
}

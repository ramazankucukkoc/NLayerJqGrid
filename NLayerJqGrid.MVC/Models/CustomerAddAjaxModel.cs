using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace NLayerJqGrid.MVC.Models
{
	public class CustomerAddAjaxModel
	{
        public CustomerForGetAllDto CustomerForGetAllDto  { get; set; }
        public string CustomerAddPartial { get; set; }
    }
}

using NLayerJqGrid.Core.Utilities.Results.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Dtos
{
	public class CustomerForGetAllDto : DtoGetBase
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string City { get; set; }
		public string County { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
	}
}

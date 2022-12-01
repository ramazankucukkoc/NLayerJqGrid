using NLayerJqGrid.Core.Utilities.Results.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Dtos
{
	public class PersonelForGetAllDto : DtoGetBase
	{
		public int Id { get; set; }
		public string PersonelName { get; set; }
		public string LastName { get; set; }
		public int DepartmanId { get; set; }
		public string DepartmanName { get; set; }

	}
}

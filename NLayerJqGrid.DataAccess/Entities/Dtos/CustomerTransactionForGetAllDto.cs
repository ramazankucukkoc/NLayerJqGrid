using NLayerJqGrid.Core.Utilities.Results.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Dtos
{
	public class CustomerTransactionForGetAllDto : DtoGetBase
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int PersonelId { get; set; }
		public int Unit { get; set; }//(Adet)
		public decimal UnitPrice { get; set; }//(Birim fiyat)
		public int TotalPrice { get; set; }
		public string Description { get; set; }
		public string ProductName { get; set; }
		public string CustomerName { get; set; }
		public string PersonelName { get; set; }

	}
}

using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;
using NLayerJqGrid.DatatAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.Entities.Concrete
{
	public class CompanyTransaction : EntityBase, IEntity
	{
		public int ProductId { get; set; }
		public int CompanyId { get; set; }
		public int PersonelId { get; set; }
		public int Unit { get; set; }//(Adet)
		public decimal UnitPrice { get; set; }//(Birim fiyat)
		public int TotalPrice { get; set; }
		public string Description { get; set; }
		public Product Product { get; set; }
		public Personel Personel { get; set; }
		public Company Company { get; set; }
	}
}

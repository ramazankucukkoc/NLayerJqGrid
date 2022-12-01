using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Concrete
{
	public class Personel : EntityBase, IEntity
	{
		public string PersonelName { get; set; }
		public string LastName { get; set; }
		public int DepartmanId { get; set; }
		public Departman Departman { get; set; }
		public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
		public ICollection<CompanyTransaction> CompanyTransactions { get; set; }


	}
}

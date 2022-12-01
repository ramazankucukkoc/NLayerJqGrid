using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Concrete
{
	public class Customer : EntityBase, IEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
		public string County { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public ICollection<CustomerTransaction> CustomerTransactions { get; set; }

	}
}

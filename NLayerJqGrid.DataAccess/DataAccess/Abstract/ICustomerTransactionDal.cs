using NLayerJqGrid.Core.DataAccess;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Abstract
{
	public interface ICustomerTransactionDal : IEntityRepository<CustomerTransaction>
	{
		List<CustomerTransaction> GetAllPersonelProductCustomerNames();

	}
}

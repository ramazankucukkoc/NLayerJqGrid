using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Concrete.EntityFramework
{
	public class EfCustomerDal : EfEntityRepositoryBase<Customer, AppDbContextBase>, ICustomerDal
	{
	}
}

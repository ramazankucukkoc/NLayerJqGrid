using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Concrete.EntityFramework
{
	public class EfCustomerTransactions : EfEntityRepositoryBase<CustomerTransaction, AppDbContextBase>, ICustomerTransactionDal
	{
		private readonly AppDbContextBase _appDbContextBase;

		public EfCustomerTransactions(AppDbContextBase appDbContextBase)
		{
			_appDbContextBase = appDbContextBase;
		}

		public List<CustomerTransaction> GetAllPersonelProductCustomerNames()
		{
			return _appDbContextBase.CustomerTransactions.Include(x => x.Product).Include(x => x.Customer).Include(x => x.Personel)
				.Where(filter => !filter.IsDeleted).ToList();

		}
	}
}

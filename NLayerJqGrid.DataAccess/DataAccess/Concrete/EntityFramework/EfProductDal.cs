
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using System.Linq.Expressions;

namespace NLayerJqGrid.DataAccess.Concrete.EntityFramework
{
	public class EfProductDal : EfEntityRepositoryBase<Product, AppDbContextBase>, IProductDal
	{
		private readonly AppDbContextBase _appDbContextBase;

		public EfProductDal(AppDbContextBase appDbContextBase)
		{
			_appDbContextBase = appDbContextBase;
		}

		public List<Product> ProductNameFilter(string productName)
		{
			return _appDbContextBase.Products.Include(x => x.Category).Where(p => p.ProdcutName.Contains(productName) || p.ProdcutName.Contains(productName)).ToList();
		}

		public List<Product> ProductWithCategory(Expression<Func<Product, bool>> filter)
		{
			return _appDbContextBase.Products.Include(x => x.Category).Where(filter => !filter.IsDeleted).ToList();
		}


	}
}



using NLayerJqGrid.Core.DataAccess;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using System.Linq.Expressions;

namespace NLayerJqGrid.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> ProductWithCategory( Expression<Func<Product, bool>> filter = null);

        List<Product> ProductNameFilter(string productName);

    }
}

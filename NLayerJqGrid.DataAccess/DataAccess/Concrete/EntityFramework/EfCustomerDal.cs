using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerJqGrid.DataAccess.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,AppDbContextBase>,ICustomerDal
    {
    }
}

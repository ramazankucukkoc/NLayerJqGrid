
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;

namespace NLayerJqGrid.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, AppDbContextBase>, IUserDal
    {

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new AppDbContextBase())
            {
                return context.OperationClaims.Include(x => x.User).ToList();

            }
        }
    }
}



using NLayerJqGrid.Core.DataAccess;
using NLayerJqGrid.Core.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

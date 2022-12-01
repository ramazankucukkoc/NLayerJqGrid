using NLayerJqGrid.Core.DataAccess;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Abstract
{
	public interface IPersonelDal : IEntityRepository<Personel>
	{
		List<Personel> GetAllNonDeletedDepartmanName();
	}
}

using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.DataAccess.EntityFramework;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Concrete.EntityFramework
{
	public class EfPersonelDal : EfEntityRepositoryBase<Personel, AppDbContextBase>, IPersonelDal
	{
		private readonly AppDbContextBase _appDbContextBase;

		public EfPersonelDal(AppDbContextBase appDbContextBase)
		{
			_appDbContextBase = appDbContextBase;
		}

		public List<Personel> GetAllNonDeletedDepartmanName()
		{
			return _appDbContextBase.Personels.Include(x => x.Departman).Where(x => !x.IsDeleted).ToList();
		}
	}
}

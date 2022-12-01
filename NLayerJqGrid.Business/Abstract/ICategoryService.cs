
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Abstract
{
	public interface ICategoryService
	{
		IDataResult<List<CategoryForGetAllDto>> GetAllNonDeleted();
		Task<IDataResult<int>> Count();
		Task<IDataResult<int>> CountByNonDeleted();
	}
}

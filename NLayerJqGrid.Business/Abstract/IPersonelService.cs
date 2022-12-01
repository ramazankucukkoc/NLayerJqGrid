using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Abstract
{
	public interface IPersonelService
	{
		IDataResult<List<PersonelForGetAllDto>> GetAllNonDeleted();


	}
}

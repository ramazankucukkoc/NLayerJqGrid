using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Abstract
{
	public interface ICustomerService
	{
		IDataResult<CustomerForGetAllDto> GetById(int entityId);
		IDataResult<List<CustomerForGetAllDto>> GetAllByNonDeleted();
		IDataResult<CustomerForGetAllDto> Add(CustomerForGetAllDto entity);
		IDataResult<CustomerForGetAllDto> Update(CustomerForGetAllDto entity);
		IDataResult<CustomerForGetAllDto> Delete(int customerId);
	}
}

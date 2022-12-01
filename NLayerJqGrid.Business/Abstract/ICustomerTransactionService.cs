using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Abstract
{
	public interface ICustomerTransactionService
	{
		IDataResult<CustomerTransactionForGetAllDto> GetById(int entityId);
		IDataResult<List<CustomerTransactionForGetAllDto>> GetAllByNonDeleted();
		IDataResult<CustomerTransactionForGetAllDto> Add(CustomerTransactionForGetAllDto entity);
		IDataResult<CustomerTransactionForGetAllDto> Update(CustomerTransactionForGetAllDto entity);
		IDataResult<CustomerTransactionForGetAllDto> Delete(int customerTransactionId);
	}
}

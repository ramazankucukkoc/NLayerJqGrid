using Business.Mapping.AutoMapper;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Concrete
{
	public class CustomerTransactionManager : ICustomerTransactionService
	{
		private readonly ICustomerTransactionDal _customerTransactionDal;

		public CustomerTransactionManager(ICustomerTransactionDal customerTransactionDal)
		{
			_customerTransactionDal = customerTransactionDal;
		}

		public IDataResult<CustomerTransactionForGetAllDto> Add(CustomerTransactionForGetAllDto entity)
		{
			var customerTransaction = ObjectMapper.Mapper.Map<CustomerTransaction>(entity);
			_customerTransactionDal.Add(customerTransaction);

			return new DataResult<CustomerTransactionForGetAllDto>(ResultStatus.Success, new CustomerTransactionForGetAllDto
			{
				Message = $"{entity.CustomerName} adlı müşteriye  başarıyla satış yapılmıştır."
			});
		}

		public IDataResult<CustomerTransactionForGetAllDto> Delete(int customerTransactionId)
		{
			var customerTransaction = _customerTransactionDal.Get(p => p.Id == customerTransactionId);
			customerTransaction.IsDeleted = true;
			customerTransaction.ModifiedByName = "Ramazan KÜÇÜKKKOÇ";

			customerTransaction.ModifiedDate = DateTime.Now;
			_customerTransactionDal.Update(customerTransaction);
			return new DataResult<CustomerTransactionForGetAllDto>(ResultStatus.Success, new CustomerTransactionForGetAllDto
			{
				ResultStatus = ResultStatus.Success,
				Message = "Müşteri başarıyla silinmiştir."
			});
		}

		public IDataResult<List<CustomerTransactionForGetAllDto>> GetAllByNonDeleted()
		{
			var getall = _customerTransactionDal.GetAllPersonelProductCustomerNames().Select(x => new CustomerTransactionForGetAllDto
			{
				Id = x.Id,
				CustomerName = x.Customer.FirstName + "" + x.Customer.LastName,
				Description = x.Description,
				PersonelName = x.Personel.PersonelName,
				ProductName = x.Product.ProdcutName,
				TotalPrice = x.TotalPrice,
				Unit = x.Unit,
				UnitPrice = x.UnitPrice
			}).ToList();

			return new DataResult<List<CustomerTransactionForGetAllDto>>(ResultStatus.Success, getall);
		}

		public IDataResult<CustomerTransactionForGetAllDto> GetById(int entityId)
		{
			var getById = _customerTransactionDal.Get(x => x.Id == entityId);
			var getByIdNoNDeleted = ObjectMapper.Mapper.Map<CustomerTransactionForGetAllDto>(getById);
			return new DataResult<CustomerTransactionForGetAllDto>(ResultStatus.Success, getByIdNoNDeleted);
		}

		public IDataResult<CustomerTransactionForGetAllDto> Update(CustomerTransactionForGetAllDto entity)
		{
			var customerTransactionDto = ObjectMapper.Mapper.Map<CustomerTransaction>(entity);

			_customerTransactionDal.Update(customerTransactionDto);
			return new DataResult<CustomerTransactionForGetAllDto>(ResultStatus.Success, new CustomerTransactionForGetAllDto
			{
				Message = "Müşteri başarıyla satışı güncellenmiştir."
			});
		}
	}
}

using Business.Mapping.AutoMapper;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Concrete
{
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public IDataResult<CustomerForGetAllDto> Add(CustomerForGetAllDto entity)
		{
			var customer = ObjectMapper.Mapper.Map<Customer>(entity);
			_customerDal.Add(customer);

			return new DataResult<CustomerForGetAllDto>(ResultStatus.Success, new CustomerForGetAllDto
			{
				Message = $"{entity.FirstName + " " + entity.LastName} adlı müşteri başarıyla eklenmiştir."
			});
		}
        public async Task<IDataResult<int>> Count()
        {
            var customerCount = await _customerDal.CountAsync();
            if (customerCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, customerCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, "Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        public async Task<IDataResult<int>> CountByNonDeleted()
        {
            var customerCount = await _customerDal.CountAsync(c => !c.IsDeleted);
            if (customerCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, customerCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, "Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }
        public IDataResult<CustomerForGetAllDto> Delete(int customerId)
		{
			var customer = _customerDal.Get(p => p.Id == customerId);
			customer.IsDeleted = true;
			customer.ModifiedByName = "Ramazan KÜÇÜKKKOÇ";
			customer.ModifiedDate = DateTime.Now;
			_customerDal.Update(customer);
			return new DataResult<CustomerForGetAllDto>(ResultStatus.Success, new CustomerForGetAllDto
			{
				ResultStatus = ResultStatus.Success,
				Message = $"{customer.FirstName + " " + customer.LastName} adlı müşteri başarıyla silinmiştir."
			});
		}

		public IDataResult<List<CustomerForGetAllDto>> GetAllByNonDeleted()
		{
			var getall = _customerDal.GetAll(p => !p.IsDeleted);
			var getAllNonDeleted = ObjectMapper.Mapper.Map<List<CustomerForGetAllDto>>(getall);
			return new DataResult<List<CustomerForGetAllDto>>(ResultStatus.Success, getAllNonDeleted);
		}

		public IDataResult<CustomerForGetAllDto> GetById(int entityId)
		{
			var getById = _customerDal.Get(x => x.Id == entityId);
			var getByIdNoNDeleted = ObjectMapper.Mapper.Map<CustomerForGetAllDto>(getById);
			return new DataResult<CustomerForGetAllDto>(ResultStatus.Success, getByIdNoNDeleted);
		}

		public IDataResult<CustomerForGetAllDto> Update(CustomerForGetAllDto entity)
		{
			var customer = ObjectMapper.Mapper.Map<Customer>(entity);
			_customerDal.Update(customer);
			return new DataResult<CustomerForGetAllDto>(ResultStatus.Success, new CustomerForGetAllDto
			{
				Message = $"{entity.FirstName + " " + entity.LastName} adlı müşteri başarıyla güncellenmiştir."
			});
		}
	}
}

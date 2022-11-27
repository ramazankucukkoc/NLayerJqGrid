using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

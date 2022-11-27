

using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<ProductForGetAllDto> GetById(int entityId);
        IDataResult<List<ProductForGetAllDto>> GetAll();
        IDataResult<List<ProductForGetAllDto>> GetAllFilterProductName(string productName);
        IDataResult<List<ProductForGetAllDto>> GetAllByNonDeleted();
        IDataResult<List<ProductForGetAllDto>> GetProductsWithCategory();
        IDataResult<ProductForGetAllDto> Add(ProductForGetAllDto entity);
        IDataResult<ProductForGetAllDto> Update(ProductForGetAllDto entity);
        IDataResult<ProductForGetAllDto> Delete(int productId);
    }
}

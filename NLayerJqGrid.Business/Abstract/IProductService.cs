

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
        /// <summary>
        /// Verilen entityId paremetresinin ProductForGetAllDto temsilini döner.
        /// </summary>
        /// <param name="id">0' dan büyük integer bit ID değeri </param>
        /// <returns>Asenkron operasyon ile Task olarak işlem sonucu DataResult tipinde geriye döner. </returns>
        IDataResult<ProductForGetAllDto> Delete(int id);
        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByNonDeleted();
    }
}

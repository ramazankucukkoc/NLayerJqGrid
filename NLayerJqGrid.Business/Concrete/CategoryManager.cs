

using Business.Mapping.AutoMapper;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public async Task<IDataResult<int>> Count()
		{
			var categoriesCount = await _categoryDal.CountAsync();
			if (categoriesCount>-1)
			{
				return new DataResult<int>(ResultStatus.Success, categoriesCount);
			}
			else
			{
				return new DataResult<int>(ResultStatus.Error, "Beklenmeyen bir hata ile karşılaşıldı.", -1);
			}
		}

		public async Task<IDataResult<int>> CountByNonDeleted()
		{
            var categoriesCount = await _categoryDal.CountAsync(c=>!c.IsDeleted);
            if (categoriesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, "Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

		public IDataResult<List<CategoryForGetAllDto>> GetAllNonDeleted()
		{
			var getallNonDeleted = _categoryDal.GetAll(p => !p.IsDeleted);
			var getall = ObjectMapper.Mapper.Map<List<CategoryForGetAllDto>>(getallNonDeleted);
			return new DataResult<List<CategoryForGetAllDto>>(ResultStatus.Success, getall);
		}
	}
}

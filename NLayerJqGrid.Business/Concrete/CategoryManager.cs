

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

		public IDataResult<List<CategoryForGetAllDto>> GetAllNonDeleted()
		{
			var getallNonDeleted = _categoryDal.GetAll(p => !p.IsDeleted);
			var getall = ObjectMapper.Mapper.Map<List<CategoryForGetAllDto>>(getallNonDeleted);
			return new DataResult<List<CategoryForGetAllDto>>(ResultStatus.Success, getall);
		}
	}
}

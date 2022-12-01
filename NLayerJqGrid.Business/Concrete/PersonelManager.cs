using Business.Mapping.AutoMapper;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DataAccess.DataAccess.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.Business.Concrete
{
	public class PersonelManager : IPersonelService
	{
		private readonly IPersonelDal _personelDal;

		public PersonelManager(IPersonelDal personelDal)
		{
			_personelDal = personelDal;

		}

		public IDataResult<List<PersonelForGetAllDto>> GetAllNonDeleted()
		{
			var getallPersonel = _personelDal.GetAll(p => !p.IsDeleted);
			var getallDtoMap = ObjectMapper.Mapper.Map<List<PersonelForGetAllDto>>(getallPersonel);
			return new DataResult<List<PersonelForGetAllDto>>(ResultStatus.Success, getallDtoMap);

		}
	}
}

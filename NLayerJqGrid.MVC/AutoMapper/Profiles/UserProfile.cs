using AutoMapper;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace NLayerJqGrid.MVC.AutoMapper.Profiles
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<UserForGetAllDto, User>().ReverseMap();
			CreateMap<UserUpdateDto, User>().ReverseMap();
			CreateMap<UserLoginDto, User>().ReverseMap();
		}
	}
}

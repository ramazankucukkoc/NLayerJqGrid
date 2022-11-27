using AutoMapper;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace NLayerJqGrid.MVC.AutoMapper.Profiles
{
	public class UserProfile:Profile
	{
		public UserProfile()
		{
			CreateMap<UserForRegisterDto, User>().ReverseMap();
		}
	}
}

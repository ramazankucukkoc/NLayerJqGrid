

using AutoMapper;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace Business.Mapping.AutoMapper
{
	public class ProductMapping : Profile
	{
		public ProductMapping()
		{
			CreateMap<ProductForGetAllDto, Product>().ReverseMap();

			CreateMap<CategoryForGetAllDto, Category>().ReverseMap();
			CreateMap<CustomerForGetAllDto, Customer>().ReverseMap();

			//CreateMap<CustomerTransaction, CustomerTransactionForGetAllDto>().ReverseMap();
			//	.AfterMap(d => d.Product.ProdcutName, o => o.MapFrom(s => s.ProductName))
			//	.AfterMap(d => d.Customer.FirstName, o => o.MapFrom(s => s.CustomerName))
			//	.AfterMap(d => d.Personel.PersonelName, o => o.MapFrom(s => s.PersonelName));

			//CreateMap<CustomerTransaction,CustomerTransactionForGetAllDto>()
			//         .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.ProdcutName))
			//         .ForMember(d => d.CustomerName, o => o.MapFrom(s => s.Customer.FirstName))
			//         .ForMember(d => d.PersonelName, o => o.MapFrom(s => s.Personel.PersonelName));
			CreateMap<CustomerTransaction, CustomerTransactionForGetAllDto>().ReverseMap();


			CreateMap<Personel, PersonelForGetAllDto>().ReverseMap();
			//.ForMember(d => d.DepartmanName, o => o.MapFrom(s => s.Departman.DepartmanName));
		}

	}
}

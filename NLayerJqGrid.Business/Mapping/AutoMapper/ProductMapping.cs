

using AutoMapper;
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


        }

    }
}

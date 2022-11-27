using Business.Mapping.AutoMapper;
using Business.Messages.Product;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DataAccess.Abstract;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        public IDataResult<ProductForGetAllDto> Add(ProductForGetAllDto entity)
        {
          var product=  ObjectMapper.Mapper.Map<Product>(entity);
             _productDal.Add(product);

            return new DataResult<ProductForGetAllDto>(ResultStatus.Success,new ProductForGetAllDto
            {
                Message=$"{entity.ProdcutName} adlı ürün başarıyla eklenmiştir."
            });
        }
        public IDataResult<ProductForGetAllDto> Delete(int id)
        {
            var product = _productDal.Get(p => p.Id == id);
            product.IsDeleted = true;
            product.ModifiedByName = "Ramazan KÜÇÜKKKOÇ";
            product.ModifiedDate = DateTime.Now;
            _productDal.Update(product);
            return new DataResult<ProductForGetAllDto>(ResultStatus.Success, new ProductForGetAllDto
            {
                ResultStatus = ResultStatus.Success,
                Message = $"{product.ProdcutName} adlı ürün başarıyla silinmiştir."
            }) ;
              
        }
        public IDataResult<List<ProductForGetAllDto>> GetAll()
        {
            throw new NotImplementedException();

        }
        public IDataResult<List<ProductForGetAllDto>> GetAllByNonDeleted()
        {
            var getall=_productDal.GetAll(p=>!p.IsDeleted);
            var getAllNonDeleted=ObjectMapper.Mapper.Map<List<ProductForGetAllDto>>(getall);
            return new DataResult<List<ProductForGetAllDto>>(ResultStatus.Success, getAllNonDeleted);   
        }

        public IDataResult<List<ProductForGetAllDto>> GetAllFilterProductName(string productName)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                var filterProductName = _productDal.ProductNameFilter(productName).Select(
                    x => new ProductForGetAllDto
                    {
                        Id = x.Id,
                        ProdcutName = x.ProdcutName,
                        Brand = x.Brand,
                        CategoryName = x.Category.CategoryName,
                        Stock = x.Stock,
                        SalesPrice = x.SalesPrice,
                        UnitPrice = x.UnitPrice
                    }).ToList();


                return new DataResult<List<ProductForGetAllDto>>(ResultStatus.Success, filterProductName);
            }
            var products = _productDal.ProductWithCategory().Select(
               x => new ProductForGetAllDto
               {
                   Id = x.Id,
                   ProdcutName = x.ProdcutName,
                   Brand = x.Brand,
                   CategoryName = x.Category.CategoryName,
                   Stock = x.Stock,
                   SalesPrice = x.SalesPrice,
                   UnitPrice = x.UnitPrice
               }).ToList();
            return new DataResult<List<ProductForGetAllDto>>(ResultStatus.Success, products);

        }

        public IDataResult<ProductForGetAllDto> GetById(int entityId)
        {
            var getById = _productDal.Get(p => p.Id == entityId);
            var getByIdNonDeleted=ObjectMapper.Mapper.Map<ProductForGetAllDto>(getById);
            return new DataResult<ProductForGetAllDto>(ResultStatus.Success, getByIdNonDeleted);
        }

        public IDataResult<List<ProductForGetAllDto>> GetProductsWithCategory()
        {
            var products = _productDal.ProductWithCategory().Select(
               x=> new ProductForGetAllDto {
                   Id = x.Id,
                   ProdcutName = x.ProdcutName,
                   Brand = x.Brand,
                   CategoryName =x.Category.CategoryName,
                   Stock = x.Stock,
                   SalesPrice = x.SalesPrice,
                   UnitPrice = x.UnitPrice                   
               }).ToList();                
            return new DataResult<List<ProductForGetAllDto>>(ResultStatus.Success, products);
        }
        public IDataResult<ProductForGetAllDto> Update(ProductForGetAllDto entity)
        {
            var product =ObjectMapper.Mapper.Map<Product>(entity);
            _productDal.Update(product);
            return new DataResult<ProductForGetAllDto>(ResultStatus.Success, new ProductForGetAllDto
            {
                Message = $"{entity.ProdcutName} adlı ürün başarıyla güncellenmiştir."
            });
        }
    }
}

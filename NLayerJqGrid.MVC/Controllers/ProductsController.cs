using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Model;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Extensions;
using NLayerJqGrid.Core.Utilities.Results.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;
using System.Text.Json;

namespace NLayerJqGrid.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }  
      
        public  JsonResult GetAllProducts(string product)
        {
            var productss = _productService.GetAllFilterProductName(product).Data;
            return Json(productss);
        }  
        [HttpGet]
        public IActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                var categoryDto = _categoryService.GetAllNonDeleted();
                ViewBag.deger1 = new SelectList(categoryDto.Data, "Id", "CategoryName");
                return PartialView("_ProductAddPartial");
            }
            else
            {
                var product = _productService.GetById(id);
                var categories = _categoryService.GetAllNonDeleted();
                ViewBag.deger1 = new SelectList(categories.Data, "Id", "CategoryName", product.Data.CategoryId);
                return PartialView("_ProductUpdatePartial", product.Data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddOrEdit  (ProductForGetAllDto product)
        {

            if (product.Id == 0)
            {

                var result =  _productService.Add(product);
                var productAddAjaxModel = JsonSerializer.Serialize(new ProductAddAjaxModel
                {
                    ProductForGetAllDto = result.Data,
                    ProductAddPartial = await this.RenderViewToStringAsync("_ProductAddPartial", product)
                });
                return Json(productAddAjaxModel);
            }
            else
            {
                var result =  _productService.Update(product);
                var productAddAjaxModel = JsonSerializer.Serialize(new ProductAddAjaxModel
                {
                    ProductForGetAllDto = result.Data,
                    ProductAddPartial = await this.RenderViewToStringAsync("_ProductUpdatePartial", product)
                });
                return Json(productAddAjaxModel);

            }

            var categoriesDto = _categoryService.GetAllNonDeleted();
            ViewBag.categories = new SelectList(categoriesDto.Data, "Id", "CategoryName");
            return View();
        }
        public IActionResult Delete(int id)
        {
            var result = _productService.Delete(id);
            var deleteProduct=JsonSerializer.Serialize(result.Data);
            return Json(deleteProduct);
        }
    }
}

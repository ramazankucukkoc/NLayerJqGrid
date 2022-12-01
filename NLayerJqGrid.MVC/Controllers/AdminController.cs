using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.MVC.Models;

namespace NLayerJqGrid.MVC.Controllers
{
    public class AdminController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly UserManager<User> _userManager;

        public AdminController(ICategoryService categoryService, 
            IProductService productService, ICustomerService customerService, UserManager<User> userManager)
        {
            _categoryService = categoryService;
            _productService = productService;
            _customerService = customerService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> Index()
        {
            var categoriesCount = await _categoryService.CountByNonDeleted();
            var productsCount = await _productService.CountByNonDeleted();
            var customersCount = await _customerService.CountByNonDeleted();
            var usersCount = await _userManager.Users.CountAsync();
            if (categoriesCount.ResultStatus ==Core.Utilities.Results.Abstract.ResultStatus.Success&&
                productsCount.ResultStatus==Core.Utilities.Results.Abstract.ResultStatus.Success
                && customersCount.ResultStatus==Core.Utilities.Results.Abstract.ResultStatus.Success&&usersCount>-1)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount=categoriesCount.Data,
                    ProductsCount=productsCount.Data,
                    CustomersCount=customersCount.Data,
                    UsersCount= usersCount
                });

            }
            return NotFound();

        }
    }
}

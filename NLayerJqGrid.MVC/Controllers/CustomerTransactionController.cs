using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Extensions;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.MVC.Models;
using System.Text.Json;

namespace NLayerJqGrid.MVC.Controllers
{
	[Authorize]

	public class CustomerTransactionController : Controller
	{
		private readonly ICustomerTransactionService _customerTransactionService;
		private readonly IProductService _productService;
		private readonly ICustomerService _customerService;
		private readonly IPersonelService _personelService;

		public CustomerTransactionController(ICustomerTransactionService customerTransactionService,
			IProductService productService, ICustomerService customerService, IPersonelService personelService)
		{
			_customerTransactionService = customerTransactionService;
			_productService = productService;
			_customerService = customerService;
			_personelService = personelService;
		}
		public IActionResult Index()
		{
			return View();
		}

		public JsonResult GetAllCustomerTransaction()
		{
			var customerTransaction = _customerTransactionService.GetAllByNonDeleted().Data;
			return Json(customerTransaction);
		}
		[HttpGet]
		public IActionResult AddOrEdit(int id)
		{
			if (id == 0)
			{
				var productDto = _productService.GetAllByNonDeleted();
				ViewBag.deger1 = new SelectList(productDto.Data, "Id", "ProdcutName");

				var customerDto = _customerService.GetAllByNonDeleted();
				ViewBag.deger2 = new SelectList(customerDto.Data, "Id", "FirstName");

				var personelDto = _personelService.GetAllNonDeleted();
				ViewBag.deger3 = new SelectList(personelDto.Data, "Id", "PersonelName");

				return PartialView("_CustomerTransactionAddPartial");
			}
			else
			{
				var customerTransaction = _customerTransactionService.GetById(id);

				var products = _productService.GetAllByNonDeleted();
				ViewBag.deger1 = new SelectList(products.Data, "Id", "ProdcutName", customerTransaction.Data.ProductId);

				var customers = _customerService.GetAllByNonDeleted();
				ViewBag.deger2 = new SelectList(customers.Data, "Id", "FirstName", customerTransaction.Data.CustomerId);

				var personels = _personelService.GetAllNonDeleted();
				ViewBag.deger3 = new SelectList(personels.Data, "Id", "PersonelName", customerTransaction.Data.PersonelId);

				return PartialView("_CustomerTransactionUpdatePartial", customerTransaction.Data);
			}
		}
		[HttpPost]
		public async Task<IActionResult> AddOrEdit(CustomerTransactionForGetAllDto customerTransactionForGetAllDto)
		{

			if (customerTransactionForGetAllDto.Id == 0)
			{

				var result = _customerTransactionService.Add(customerTransactionForGetAllDto);
				var customerTransactionAddAjaxModel = JsonSerializer.Serialize(new CustomerTransactionAddAjaxModel
				{
					CustomerTransactionForGetAllDto = result.Data,
					CustomerTransactionAddPartial = await this.RenderViewToStringAsync("_CustomerTransactionAddPartial", customerTransactionForGetAllDto)
				});
				return Json(customerTransactionAddAjaxModel);
			}
			else
			{
				var result = _customerTransactionService.Update(customerTransactionForGetAllDto);
				var customerTransactionAddAjaxModel = JsonSerializer.Serialize(new CustomerTransactionAddAjaxModel
				{
					CustomerTransactionForGetAllDto = result.Data,
					CustomerTransactionAddPartial = await this.RenderViewToStringAsync("_CustomerTransactionUpdatePartial", customerTransactionForGetAllDto)
				});
				return Json(customerTransactionAddAjaxModel);

			}

			var productDto = _productService.GetAllByNonDeleted();
			ViewBag.deger1 = new SelectList(productDto.Data, "Id", "ProdcutName");

			var customerDto = _customerService.GetAllByNonDeleted();
			ViewBag.deger2 = new SelectList(customerDto.Data, "Id", "FirstName");

			var personelDto = _personelService.GetAllNonDeleted();
			ViewBag.deger3 = new SelectList(personelDto.Data, "Id", "PersonelName");
			return View();
		}
		public IActionResult Delete(int id)
		{
			var result = _customerTransactionService.Delete(id);
			var deleteProduct = JsonSerializer.Serialize(result.Data);
			return Json(deleteProduct);
		}

	}
}

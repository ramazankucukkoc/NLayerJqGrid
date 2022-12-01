using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLayerJqGrid.Business.Abstract;
using NLayerJqGrid.Core.Extensions;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.MVC.Models;
using System.Text.Json;

namespace NLayerJqGrid.MVC.Controllers
{
	[Authorize]
	public class CustomersController : Controller
	{
		private readonly ICustomerService _customerService;

		public CustomersController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public JsonResult GetAllCustomers()
		{
			var customers = _customerService.GetAllByNonDeleted().Data;
			return Json(customers);
		}
		[HttpGet]
		public IActionResult AddOrEdit(int id)
		{
			if (id == 0)
			{
				return PartialView("_CustomerAddPartial");
			}
			else
			{
				var product = _customerService.GetById(id);
				return PartialView("_CustomerUpdatePartial", product.Data);
			}
		}
		[HttpPost]
		public async Task<IActionResult> AddOrEdit(CustomerForGetAllDto customer)
		{

			if (customer.Id == 0)
			{

				var result = _customerService.Add(customer);
				var productAddAjaxModel = JsonSerializer.Serialize(new CustomerAddAjaxModel
				{
					CustomerForGetAllDto = result.Data,
					CustomerAddPartial = await this.RenderViewToStringAsync("_CustomerAddPartial", customer)
				});
				return Json(productAddAjaxModel);
			}
			else
			{
				var result = _customerService.Update(customer);
				var customerAddAjaxModel = JsonSerializer.Serialize(new CustomerAddAjaxModel
				{
					CustomerForGetAllDto = result.Data,
					CustomerAddPartial = await this.RenderViewToStringAsync("_CustomerUpdatePartial", customer)
				});
				return Json(customerAddAjaxModel);

			}
			return View();
		}
		public IActionResult Delete(int id)
		{
			var result = _customerService.Delete(id);
			var deleteProduct = JsonSerializer.Serialize(result.Data);
			return Json(deleteProduct);
		}


	}
}

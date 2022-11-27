using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Model;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.Core.Extensions;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;
using System.Text.Json;

namespace NLayerJqGrid.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;

        public UsersController(UserManager<User> userManager, IWebHostEnvironment env, IMapper mapper)
        {
            _mapper = mapper;
            _userManager = userManager;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList().Select(x => new UserListDto
            {
                UserName = x.UserName,
                Email = x.Email,
                Id = x.Id,
                PhoneNumber = x.PhoneNumber,
                Picture=x.Picture,
                ResultStatus=Core.Utilities.Results.Abstract.ResultStatus.Success
            }));
        }
        public JsonResult GetUsers()
        {
            return Json(_userManager.Users.ToList().Select(x => new UserListDto
            {
                UserName = x.UserName,
                Email = x.Email,
                Id = x.Id,
                PhoneNumber = x.PhoneNumber,
                Picture = x.Picture
            }));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_UserAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult>Add(UserForRegisterDto userForRegisterDto)
        {
            if (ModelState.IsValid)
            {
                userForRegisterDto.Picture = await ImageUpload(userForRegisterDto);
                var user = _mapper.Map<User>(userForRegisterDto);
                var result = await _userManager.CreateAsync(user, userForRegisterDto.Password);             
                if (result.Succeeded)
                {
                    var userAddAjaxModel = JsonSerializer.Serialize(new UserAddAjaxModel
                    {
                        User = user,
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userForRegisterDto)
                    });
                    return Json(userAddAjaxModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var userAddAjaxErrorModel = JsonSerializer.Serialize(new UserAddAjaxModel
                    {
                        UserForRegisterDto = userForRegisterDto,
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userForRegisterDto)
                    });
                    return Json(userAddAjaxErrorModel);
                }
            }        
                var userAddAjaxModelStateErrorModel = JsonSerializer.Serialize(new UserAddAjaxModel
                {
                    UserForRegisterDto = userForRegisterDto,
                    UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userForRegisterDto)
                });
                return Json(userAddAjaxModelStateErrorModel);      
        }
        public async Task<string>ImageUpload(UserForRegisterDto userForRegisterDto)
        {
            string wwwroot=_env.WebRootPath;

            string fileExtension =Path.GetExtension(userForRegisterDto.PictureFile.FileName);

            DateTime dateTime = DateTime.Now;

            string fileName = $"{userForRegisterDto.UserName}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            
            var path = Path.Combine($"{wwwroot}/img", fileName);

            await using (var stream =new FileStream(path,FileMode.Create))
            {
                await userForRegisterDto.PictureFile.CopyToAsync(stream);
            }
            return fileName;
        }
        public async Task<JsonResult>Delete(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var result =await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
               var deletedUser =JsonSerializer.Serialize(user);
                return Json(deletedUser);
            }
           return Json(null);
        }
    }
}

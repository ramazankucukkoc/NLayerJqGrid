using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Model;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.Core.Extensions;
using NLayerJqGrid.DataAccess.Entities.Dtos;
using NLayerJqGrid.DatatAccess.Entities.Dtos;
using NLayerJqGrid.MVC.Helpers.Abstract;
using System.Text.Json;

namespace NLayerJqGrid.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public UsersController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IImageHelper imageHelper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View("UserLogin");
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                        return View("UserLogin");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                    return View("UserLogin");
                }
            }
            else
            {
                return View("UserLogin");
            }
        }

        [Authorize(Roles = "Admin")]
        public JsonResult GetUsers()
        {
            return Json(_userManager.Users.ToList().Select(x => new UserForGetAllDto
            {
                UserName = x.UserName,
                Email = x.Email,
                Id = x.Id,
                PhoneNumber = x.PhoneNumber,
                Picture = x.Picture
            }));
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_UserAddPartial");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Add(UserForGetAllDto userForRegisterDto)
        {
            if (ModelState.IsValid)
            {
              var uploadedImageDtoResult = await _imageHelper.UploadUserImage(userForRegisterDto.UserName, userForRegisterDto.PictureFile);
                userForRegisterDto.Picture = uploadedImageDtoResult.ResultStatus == Core.Utilities.Results.Abstract.ResultStatus.Success
                    ? uploadedImageDtoResult.Data.FullName
                    : "userImages/defaultUser.png";

                var user = _mapper.Map<User>(userForRegisterDto);
                var result = await _userManager.CreateAsync(user, userForRegisterDto.Password);
                if (result.Succeeded)
                {
                    var userMap = _mapper.Map<UserForGetAllDto>(user);
                    var userAddAjaxModel = JsonSerializer.Serialize(new UserAddAjaxModel
                    {
                        UserForGetAllDto = userMap,
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
                        UserForGetAllDto = userForRegisterDto,
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userForRegisterDto)
                    });
                    return Json(userAddAjaxErrorModel);
                }
            }
            var userAddAjaxModelStateErrorModel = JsonSerializer.Serialize(new UserAddAjaxModel
            {
                UserForGetAllDto = userForRegisterDto,
                UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userForRegisterDto)
            });
            return Json(userAddAjaxModelStateErrorModel);
        }
        [HttpGet]

        public ViewResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<ViewResult> ChangeDetails()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var updateDto = _mapper.Map<UserUpdateDto>(user);
            return View(updateDto);
        }
        [Authorize]
        [HttpPost]
        public async Task<ViewResult> ChangeDetails(UserUpdateDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldUser = await _userManager.GetUserAsync(HttpContext.User);
                var oldUserPicture = oldUser.Picture;
                if (userUpdateDto.PictureFile != null)
                {
                    var uploadedImageDtoResult = await _imageHelper.UploadUserImage(userUpdateDto.UserName, userUpdateDto.PictureFile);
                    userUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == Core.Utilities.Results.Abstract.ResultStatus.Success
                        ? uploadedImageDtoResult.Data.FullName
                        : "userImages/defaultUser.png"; 
                    if (oldUserPicture != "userImages/defaultUser.png")
                    {
                        isNewPictureUploaded = true;
                    }

                }
                var updatedUser = _mapper.Map<UserUpdateDto, User>(userUpdateDto, oldUser);
                var result = await _userManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded == true)
                    {
                        _imageHelper.DeleteImage(oldUserPicture);
                    }
                    TempData.Add("SuccessMessage", $"{updatedUser.UserName} adlı kullanıcı başarıyla güncellenmiştir.");
                    return View(userUpdateDto);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(userUpdateDto);
                }
            }
            else
            {
                return View(userUpdateDto);
            }
        }
        [Authorize]
        [HttpGet]
        public ViewResult PasswordChange()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PasswordChange(UserPasswordChangeDto userPasswordChangeDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var isVerifed = await _userManager.CheckPasswordAsync(user, userPasswordChangeDto.CurrentPassword);
                if (isVerifed)
                {
                    var result = await _userManager.ChangePasswordAsync(user, userPasswordChangeDto.CurrentPassword, userPasswordChangeDto.NewPassword);
                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, userPasswordChangeDto.NewPassword, true, false);
                        TempData.Add("SuccessMessage", "Şifreniz başarıyla değiştirilmiştir.");
                        return View();
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(userPasswordChangeDto);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen, girmiş olduğunuz şu anki şifrenizi kontrol ediniz.");
                    return View(userPasswordChangeDto);
                }
            }
            else
            {
                return View(userPasswordChangeDto);

            }
        }
        [Authorize(Roles = "Admin")]
        public async Task<JsonResult> Delete(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var result = await _userManager.DeleteAsync(user);
            var userDto = _mapper.Map<UserForGetAllDto>(user);
            if (result.Succeeded)
            {
                var deletedUser = JsonSerializer.Serialize(new UserForGetAllDto
                {
                    ResultStatus = Core.Utilities.Results.Abstract.ResultStatus.Success,
                    Message = $"{userDto.UserName} adlı kullanıcı adına sahip kullanıcı başarıyla silinmiştir."
                });
                return Json(deletedUser);
            }
            return Json(null);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<PartialViewResult> Update(int userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            var userUpdateDto = _mapper.Map<UserUpdateDto>(user);
            return PartialView("_UserUpdatePartial", userUpdateDto);
        }
        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldUser = await _userManager.FindByIdAsync(userUpdateDto.Id.ToString());
                var oldUserPicture = oldUser.Picture;
                if (userUpdateDto.PictureFile != null)
                {
                    var uploadedImageDtoResult = await _imageHelper.UploadUserImage(userUpdateDto.UserName, userUpdateDto.PictureFile);
                    userUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == Core.Utilities.Results.Abstract.ResultStatus.Success
                        ? uploadedImageDtoResult.Data.FullName
                        : "userImages/defaultUser.png";
                    if (oldUserPicture != "userImages/defaultUser.png")
                    {
                        isNewPictureUploaded = true;
                    }

                }
                var updatedUser = _mapper.Map<UserUpdateDto, User>(userUpdateDto, oldUser);
                var result = await _userManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded == true)
                    {
                        _imageHelper.DeleteImage(oldUserPicture);
                    }
                    var userUpdateViewModelModel = JsonSerializer.Serialize(new UserUpdateAjaxModel
                    {
                        User = updatedUser,
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)
                    });
                    return Json(userUpdateViewModelModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var userUpdateErrorViewModelModel = JsonSerializer.Serialize(new UserUpdateAjaxModel
                    {
                        UserUpdateDto = userUpdateDto,
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)
                    });
                    return Json(userUpdateErrorViewModelModel);
                }
            }
            else
            {
                var userUpdateErrorModelStateViewModelModel = JsonSerializer.Serialize(new UserUpdateAjaxModel
                {
                    UserUpdateDto = userUpdateDto,
                    UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)
                });
                return Json(userUpdateErrorModelStateViewModelModel);
            }
        }
    }
}

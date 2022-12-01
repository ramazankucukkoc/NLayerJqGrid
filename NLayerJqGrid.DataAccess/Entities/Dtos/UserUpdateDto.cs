﻿using Microsoft.AspNetCore.Http;
using NLayerJqGrid.Core.Utilities.Results.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NLayerJqGrid.DataAccess.Entities.Dtos
{
	public class UserUpdateDto : DtoGetBase
	{

		[Required]
		public int Id { get; set; }
		[DisplayName("Kullanıcı Adı")]
		[Required(ErrorMessage = "{0} boş geçilmemelidir.")]
		[MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
		public string UserName { get; set; }

		[DisplayName("E-Posta Adresi")]
		[Required(ErrorMessage = "{0} boş geçilmemelidir.")]
		[MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
		[MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		//[DisplayName("Şifre")]
		//[Required(ErrorMessage = "{0} boş geçilmemelidir.")]
		//[MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
		//[MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
		//[DataType(DataType.Password)]

		//public string Password { get; set; }

		[DisplayName("Telefon Numarası")]
		[Required(ErrorMessage = "{0} boş geçilmemelidir.")]
		[MaxLength(13, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
		[MinLength(13, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
		[DataType(DataType.PhoneNumber)]

		public string PhoneNumber { get; set; }

		[DisplayName("Resim Ekle")]
		[Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
		public IFormFile? PictureFile { get; set; }

		[DisplayName("Resim")]
		public string? Picture { get; set; }
	}
}

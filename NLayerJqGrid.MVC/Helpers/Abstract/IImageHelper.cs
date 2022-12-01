using NLayerJqGrid.Core.Utilities.Results.Abstract;
using NLayerJqGrid.DataAccess.Entities.Dtos;

namespace NLayerJqGrid.MVC.Helpers.Abstract
{
	public interface IImageHelper
	{
		Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
		IDataResult<ImageDeletedDto> DeleteImage(string pictureName);


	}
}

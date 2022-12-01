using Microsoft.AspNetCore.Identity;

namespace NLayerJqGrid.Core.Entities.Concrete
{
	public class User : IdentityUser<int>
	{
		public string? Picture { get; set; }


	}
}

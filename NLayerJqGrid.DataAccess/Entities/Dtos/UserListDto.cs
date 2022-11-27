using NLayerJqGrid.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerJqGrid.DataAccess.Entities.Dtos
{
	public class UserListDto:DtoGetBase
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
        public string? Picture { get; set; }


    }
}

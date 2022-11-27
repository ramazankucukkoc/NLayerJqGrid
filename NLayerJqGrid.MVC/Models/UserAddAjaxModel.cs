﻿
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Dtos;

namespace MVC.Model
{
    public class UserAddAjaxModel
    {
        public UserForRegisterDto UserForRegisterDto { get; set; }
        public User User  { get; set; }
        public string UserAddPartial { get; set; }
    }
}

using NLayerJqGrid.Core.Utilities.Results.Abstract;

namespace NLayerJqGrid.DatatAccess.Entities.Dtos
{
    public class CategoryForGetAllDto :DtoGetBase
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}

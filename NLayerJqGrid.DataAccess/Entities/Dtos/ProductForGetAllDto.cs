

using NLayerJqGrid.Core.Utilities.Results.Abstract;

namespace NLayerJqGrid.DatatAccess.Entities.Dtos
{
    public class ProductForGetAllDto :DtoGetBase
    {
        public int Id { get; set; }
        public string ProdcutName { get; set; }
        public string? Brand { get; set; }
        public short Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public string CategoryName { get; set; }


    }
}

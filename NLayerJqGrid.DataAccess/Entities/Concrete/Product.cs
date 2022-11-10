using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;


namespace NLayerJqGrid.DatatAccess.Entities.Concrete
{
    public class Product :EntityBase, IEntity
    {
        public string ProdcutName { get; set; }
        public string? Brand { get; set; }
        public short Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public int CategoryId { get; set; } 
        public Category Category { get; set; }


    }
}

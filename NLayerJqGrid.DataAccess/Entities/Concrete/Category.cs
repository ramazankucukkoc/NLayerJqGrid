

using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;

namespace NLayerJqGrid.DatatAccess.Entities.Concrete
{
    public class Category :EntityBase, IEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}

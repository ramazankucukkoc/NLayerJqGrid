using NLayerJqGrid.Core.Entities;
using NLayerJqGrid.DatatAccess.Entities.Abstract;

namespace NLayerJqGrid.DataAccess.Entities.Concrete
{
	public class Departman : EntityBase, IEntity
	{
		public string DepartmanName { get; set; }
		public ICollection<Personel> Personels { get; set; }
	}
}

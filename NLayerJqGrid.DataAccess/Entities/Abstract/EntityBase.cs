namespace NLayerJqGrid.DatatAccess.Entities.Abstract
{
	public abstract class EntityBase
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
		public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
		public virtual bool IsDeleted { get; set; } = false;
		public virtual string CreatedByName { get; set; } = "Ramazan KÜÇÜKKOÇ";
		public virtual string ModifiedByName { get; set; } = "Ramazan KÜÇÜKKOÇ";
		public virtual string Note { get; set; } = "Not girilmedi";


	}
}

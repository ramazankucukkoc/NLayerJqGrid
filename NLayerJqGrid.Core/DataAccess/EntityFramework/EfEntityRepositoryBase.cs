using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.Entities;
using System.Linq.Expressions;

namespace NLayerJqGrid.Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public void Add(TEntity entity)
		{
			using (var context = new TContext())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Added;
				context.SaveChanges();
			}

		}

		public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
		{
			using (var context =new TContext())
			{
                return await (predicate == null ? context.Set<TEntity>().CountAsync() : context.Set<TEntity>().CountAsync(predicate));

            }
        }

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}// patlama sebebi aynı kayıt ikili tekrar ettigi için.

		public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return filter == null
					? context.Set<TEntity>().ToList()
					: context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public void Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updateEntity = context.Entry(entity);
				updateEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}

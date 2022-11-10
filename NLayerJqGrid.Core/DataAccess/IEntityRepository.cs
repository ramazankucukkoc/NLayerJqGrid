﻿using NLayerJqGrid.Core.Entities;
using System.Linq.Expressions;

namespace NLayerJqGrid.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);

        IList<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

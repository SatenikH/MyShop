using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EFMyShop
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IReadOnlyRepository<TEntity>
        where TEntity : class, new()
    {
        bool Any(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int id);
    }
}

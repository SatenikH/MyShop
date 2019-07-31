using System.Collections.Generic;

namespace EFMyShop
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IActionRepository<TEntity>
       where TEntity : class, new()
    {
        void Create(TEntity entity);
        void CreateMany(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteById(int id);
        void DeleteRange(IEnumerable<TEntity> entities);
    }

}

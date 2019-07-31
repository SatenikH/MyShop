
namespace EFMyShop
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> : IActionRepository<TEntity>, IReadOnlyRepository<TEntity>
        where TEntity : class, new()
    { }

    public interface IBaseRepository<TEntity, TKey> : IBaseRepository<TEntity>
        where TEntity : class, new()
    {
        TEntity Find(TKey id);
    }

}

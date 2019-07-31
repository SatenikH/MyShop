using EFMyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMyShop.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context) { }

        public Order Find(int id)
        {
            throw new System.NotImplementedException();
        }
    }

}

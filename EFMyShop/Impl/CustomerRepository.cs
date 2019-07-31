using EFMyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMyShop.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context) { }

        public Customer Find(int id)
        {
            throw new System.NotImplementedException();
        }
    }

}

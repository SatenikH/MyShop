using EFMyShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMyShop.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            Customer = new CustomerRepository(_dbContext);
            Order = new OrderRepository(_dbContext);
        }

        public ICustomerRepository Customer { get; }
        public OrderRepository Order { get; }

        IOrderRepository IUnitOfWork.Order => throw new NotImplementedException();

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void RejectChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

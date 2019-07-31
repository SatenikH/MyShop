using System;

namespace EFMyShop
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        IOrderRepository Order { get; }

        void Commit();
        void RejectChanges();
        void Dispose();
    }

}

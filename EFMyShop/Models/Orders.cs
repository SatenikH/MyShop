using System;

namespace EFMyShop.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer Customer { get; set; }
    }
}

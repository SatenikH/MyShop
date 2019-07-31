using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMyShop.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        [Column(TypeName = "Image")]
        public byte[] Photo { get; set; }
        public List<Order> Orders { get; set; }
    }
}

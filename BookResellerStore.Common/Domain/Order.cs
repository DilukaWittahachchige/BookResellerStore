using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStore.Common.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public string OrderStatus { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

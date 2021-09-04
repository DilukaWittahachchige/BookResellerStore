using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStore.Common.Domain
{
    public class Price
    {
        public int PriceId { get; set; }
        public double BookPrice { get; set; }
        public double Discount { get; set; }
        public int StoreId { get; set; }
        public int BookId { get; set; }
        public string CurrencyCode { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

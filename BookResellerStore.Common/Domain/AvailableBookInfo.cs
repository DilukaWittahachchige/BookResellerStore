using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreCommon.Domain
{
    public class AvailableBookInfo
    {
        public string IsbnCode { get; set; }
        public string BookName { get; set; }
        public string AutherName { get; set; }
        public Dictionary<string, double> PriceRange { get; set; }
        public double stock { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStore.Common.Domain
{
    public class Book
    {
        public string BookId { get; set; }
        public string IsbnCode { get; set; }
        public string Auther { get; set; }
        public string BookName { get; set; }
        //Default CreatedUserId = 000000(System)
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

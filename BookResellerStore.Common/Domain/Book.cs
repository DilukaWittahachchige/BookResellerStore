using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStore.Common.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string IsbnCode { get; set; }
        public int AutherId { get; set; }
        public string BookName { get; set; }
        //If stock empty then this flag auto update to false
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        //Default CreatedUserId = 000000(System)
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

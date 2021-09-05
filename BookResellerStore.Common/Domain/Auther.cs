using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreCommon.Domain
{
    public class Auther
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

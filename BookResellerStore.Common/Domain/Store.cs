
namespace BookResellerStore.Common.Domain
{
    #region directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string PhoneNumner { get; set; }
        public string Address { get; set; }
        public int BankAccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

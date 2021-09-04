
namespace BookResellerStore.Common.Domain
{
    #region
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumner { get; set; }
        public string Address { get; set; }
        public int BankAccountNumber { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

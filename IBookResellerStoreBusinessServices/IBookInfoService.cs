using BookResellerStore.Common.Domain;
using BookResellerStoreCommon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookResellerStoreBusinessServices
{
    public interface IBookInfoService
    {
        IEnumerable<AvailableBookInfo> LoadAllBookInfo();
    }
}

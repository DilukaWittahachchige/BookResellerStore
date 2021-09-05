using BookResellerStore.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookResellerStoreDataAccess.IRepositories
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        //Second method
        IEnumerable<Book> LoadByName(string searchString);
    }
}

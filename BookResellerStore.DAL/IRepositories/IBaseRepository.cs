using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookResellerStoreDataAccess.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        //Use Async Task operations, becasue future plan to load data from DB
        IEnumerable<T> LoadAll();
        //T LoadById(long id);
        //void Add(T dataModel);
        //void Update(T dataModel);
        //void Delete (T dataModel);
    }
}

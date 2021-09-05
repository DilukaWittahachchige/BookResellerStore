using BookResellerStoreCommon.Dummy;
using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDataAccess
{
    /// <summary>
    ///  Base Repository 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRepository<T> : IBaseRepository<T> where  T : class
    {
        public abstract IEnumerable<T> LoadAll();

        //public virtual T LoadById(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void Add(T dataModel)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void Update(T dataModel)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void Delete(T dataModel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

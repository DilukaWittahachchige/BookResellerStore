using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Generic;
 
namespace BookResellerStoreDataAccess
{
    /// <summary>
    ///  Base Repository 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        //TODO: Later plan to integrate ORM - EF Core 
        public BaseRepository()
        {
           
        }

        public abstract IEnumerable<T> LoadAll();

        public virtual T LoadById(int id)
        {
            throw new NotImplementedException();
        }

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

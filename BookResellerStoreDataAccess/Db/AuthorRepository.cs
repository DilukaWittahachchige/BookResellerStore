using BookResellerStoreCommon.Domain;
using BookResellerStoreCommon.Dummy;
using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDataAccess.Db
{
    public class AuthorRepository : IAuthorRepository
    {
        public IEnumerable<Auther> LoadAll()
        {
            return DummyDataModel.Authers;
        }

        public Auther LoadById(int id)
        {
            return DummyDataModel.Authers.FirstOrDefault(x => x.Id == id);
        }
    }
}

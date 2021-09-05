using BookResellerStore.Common.Domain;
using BookResellerStoreCommon.Dummy;
using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDataAccess
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> LoadAll()
        {
            return DummyDataModel.Users;
        }

        public User LoadById(int id)
        {
            return DummyDataModel.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}

using BookResellerStore.Common.Domain;
using BookResellerStoreCommon.Domain;
using BookResellerStoreCommon.Dummy;
using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDataAccess
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> LoadAll()
        {
            return DummyDataModel.Books;
        }

        public Book LoadById(int id)
        {
            return DummyDataModel.Books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> LoadByName(string searchString)
        {
            return DummyDataModel.Books.Where(x => x.BookName.Contains(searchString));
        }
    }
}

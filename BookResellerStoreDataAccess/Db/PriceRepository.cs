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
    public class PriceRepository: IPriceRepository
    {
        /// <summary>
        ///  Load all price info
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Price> LoadAll()
        {
            return DummyDataModel.Prices;
        }

        /// <summary>
        ///  load price info by Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Price LoadById(int id)
        {
            return DummyDataModel.Prices.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Price> LoadByBookId(int bookId)
        {
            return DummyDataModel.Prices.Where(x => x.BookId == bookId);
        }
    }
}

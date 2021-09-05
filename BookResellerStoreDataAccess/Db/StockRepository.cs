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
    public class StockRepository : IStockRepository
    {
        /// <summary>
        /// Load All stocks 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Stock> LoadAll()
        {
            return DummyDataModel.Stocks;
        }

        /// <summary>
        /// Stock info by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Stock LoadById(int id)
        {
            return DummyDataModel.Stocks.FirstOrDefault(x => x.Id == id);
        }
    }
}

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
        public IEnumerable<Stock> LoadAll()
        {
            return DummyDataModel.Stocks;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookResellerStoreDataAccess.IRepositories
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPriceRepository PriceRepository { get; }
        IStockRepository StockRepository { get; }
        IStoreRepository StoreRepository { get; }
        IUserRepository UserRepository { get; }
    }
}

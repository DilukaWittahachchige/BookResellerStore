using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDataAccess.Db
{
    public class UnitOfWork : IUnitOfWork
    {
        private AuthorRepository _authorRepository;
        private BookRepository _bookRepository;
        private OrderRepository _orderRepository;
        private PriceRepository _priceRepository;
        private StockRepository _stockRepository;
        private StoreRepository _storeRepository;
        private UserRepository _userRepository;

        public UnitOfWork()
        {
        }

        public IAuthorRepository AuthorRepository
        {
            get
            {
                return _authorRepository ??
                    (_authorRepository = new AuthorRepository());
            }
        }

        public IBookRepository BookRepository
        {
            get
            {
                return _bookRepository ??
                    (_bookRepository = new BookRepository());
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository ??
                    (_orderRepository = new OrderRepository());
            }
        }

        public IPriceRepository PriceRepository
        {
            get
            {
                return _priceRepository ??
                    (_priceRepository = new PriceRepository());
            }
        }

        public IStockRepository StockRepository
        {
            get
            {
                return _stockRepository ??
                    (_stockRepository = new StockRepository());
            }
        }

        public IStoreRepository StoreRepository
        {
            get
            {
                return _storeRepository ??
                    (_storeRepository = new StoreRepository());
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ??
                    (_userRepository = new UserRepository());
            }
        }
    }
}

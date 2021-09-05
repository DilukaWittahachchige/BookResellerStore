
using BookResellerStore.Common.Domain;
using BookResellerStoreCommon.Domain;
using BookResellerStoreDataAccess.Db;
using IBookResellerStoreBusinessServices;
using IBookResellerStoreDataAccess.IRepositories;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreBusinessServices
{
    /// <summary>
    ///  BookInfoService
    /// </summary>
    public class BookInfoService : IBookInfoService
    {
        /// <summary>
        ///   BookRepository
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        public BookInfoService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<AvailableBookInfo> LoadAllBookInfo()
        {
            var allbooks = this._unitOfWork.BookRepository.LoadAll();
            var allbooksInfo = new ConcurrentBag<AvailableBookInfo>();
           

            Parallel.ForEach(allbooks, book =>
            {
                if (IsStockAvailable(book))
                {
                    var availableBookInfo = new AvailableBookInfo();
                    availableBookInfo.BookName = book.BookName;
                    availableBookInfo.IsbnCode = book.IsbnCode;
                    availableBookInfo.AutherName = this.LoadAuthorName(book.AutherId);
                    availableBookInfo.PriceRange = this.LoadPriceRange(book.Id);
                    availableBookInfo.stock = this.LoadTotalStockByBookId(book.Id);

                    allbooksInfo.Add(availableBookInfo);
                }
            });

            return allbooksInfo;
        }

        private bool IsStockAvailable(Book book)
        {
            if (!book.IsDeleted && book.IsAvailable)
            {
                return true;
            }
            return false;
        }

        private string LoadAuthorName(int autherId)
        {
            return this._unitOfWork.AuthorRepository.LoadById(autherId).Name;
        }

        private Dictionary<string, double> LoadPriceRange (int bookId)
        {
            var priceInfo = this._unitOfWork.PriceRepository.LoadByBookId(bookId);
            var maxPrice = priceInfo.ToList().Max(x => x.BookPrice);
            var minPrice = priceInfo.ToList().Min(x => x.BookPrice);

            var priceRange = new Dictionary<string, double>();
            priceRange.Add("MinPrice", minPrice);
            priceRange.Add("MaxPrice", maxPrice);

            return priceRange;
        }

        private double LoadTotalStockByBookId(int bookId)
        {
            var stockInfo = this._unitOfWork.StockRepository.LoadAll().Where(x => x.BookId == bookId);
            return stockInfo.Select(t => t.Quantity).Sum();
        }
    }
}

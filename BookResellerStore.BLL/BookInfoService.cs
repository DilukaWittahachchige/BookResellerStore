
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
            var availableBookInfo = new AvailableBookInfo();
            var allbooksInfo = new ConcurrentBag<AvailableBookInfo>();

            Parallel.ForEach(allbooks, book =>
            {
                if (IsStockAvailable(book))
                {
                    availableBookInfo.BookName = book.BookName;
                    availableBookInfo.IsbnCode = book.IsbnCode;
                }
                allbooksInfo.Add(availableBookInfo);
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
    }
}

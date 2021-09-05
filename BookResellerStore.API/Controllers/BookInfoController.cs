using BookResellerStoreCommon.Domain;
using BookResellerStoreCommon.Dummy;
using IBookResellerStoreBusinessServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookResellerStore.API.Controllers
{
    //[Authorize]
    [Route("api/book-info")]
    [ApiController]
    public class BookInfoController : ControllerBase
    {
        /// <summary>
        ///  IBookInfoService interface
        /// </summary>
        private readonly IBookInfoService _bookInfoService;

        /// <summary>
        /// BookInfo Controller
        /// </summary>
        /// <param name="bookInfoService"></param>
        public BookInfoController(IBookInfoService bookInfoService)
        {
            Data.LoadDummyModel();
            this._bookInfoService = bookInfoService;
        }

        /// <summary>
        /// Load All book information
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<AvailableBookInfo> LoadAllBookInfo()
        {
            return this._bookInfoService.LoadAllBookInfo();
        }

        [HttpGet("{id}")]
        public IEnumerable<AvailableBookInfo> LoadAllBookInfo(int id)
        {
            return this._bookInfoService.LoadAllBookInfo();
        }

    }
}

using BookResellerStore.Common.Domain;
using BookResellerStoreCommon.Domain;
using BookResellerStoreCommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreCommon.Dummy
{
    public static class Data
    {
        public static void LoadDummyModel()
        {
            DummyDataModel.Books = DummyDataManager.LoadDummyBooks();
            DummyDataModel.Authers = DummyDataManager.LoadDummyAuthers();
            DummyDataModel.Prices = DummyDataManager.LoadDummyPrices();
            DummyDataModel.Stocks = DummyDataManager.LoadDummyStocks();
            DummyDataModel.Stores = DummyDataManager.LoadDummyStore();
            DummyDataModel.Users = DummyDataManager.LoadDummyUsers();
            DummyDataModel.Orders = DummyDataManager.LoadDummyOrders();
        }
    }

    public static class DummyDataModel
    {
        public static IEnumerable<Book> Books { get; set; }
        public static IEnumerable<Auther> Authers { get; set; }
        public static IEnumerable<Order> Orders { get; set; }
        public static IEnumerable<Price> Prices { get; set; }
        public static IEnumerable<Stock> Stocks { get; set; }
        public static IEnumerable<Store> Stores { get; set; }
        public static IEnumerable<User> Users { get; set; }
    }

    public static class DummyDataManager
    {
        public static IEnumerable<Book> LoadDummyBooks()
        {
            var dummyBookOne = new Book()
            {
                BookId = 1,
                IsbnCode = "500-3-16-148410-0",
                AutherId = 1,
                BookName = "Abc_Story",
                IsAvailable = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyBookTwo = new Book()
            {
                BookId = 2,
                IsbnCode = "600-3-16-148410-0",
                AutherId = 4,
                BookName = "Aww_Story",
                IsAvailable = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyBookThree = new Book()
            {
                BookId = 3,
                IsbnCode = "100-3-16-148410-0",
                AutherId = 1,
                BookName = "Avv_Story",
                IsAvailable = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyBookFour = new Book()
            {
                BookId = 4,
                IsbnCode = "700-3-16-148410-0",
                AutherId = 2,
                BookName = "Acc_Story",
                IsAvailable = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyBookFive = new Book()
            {
                BookId = 5,
                IsbnCode = "900-3-16-678410-0",
                AutherId = 4,
                BookName = "Abcd_Story",
                IsAvailable = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allBooks = new List<Book>();
            allBooks.Add(dummyBookOne);
            allBooks.Add(dummyBookTwo);
            allBooks.Add(dummyBookThree);
            allBooks.Add(dummyBookFour);
            allBooks.Add(dummyBookFive);

            return allBooks;
        }

        public static IEnumerable<Auther> LoadDummyAuthers()
        {
            var dummyAutherOne = new Auther()
            {
                Id = 1,
                Name = "Auther_One",
                Email = "auther@gmail.com",
                Phone = "+6578654320",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyAutherTwo = new Auther()
            {
                Id = 2,
                Name = "Auther_Two",
                Email = "auther2@gmail.com",
                Phone = "+6578657720",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyAutherThree = new Auther()
            {
                Id = 3,
                Name = "Auther_three",
                Email = "auther@gmail.com",
                Phone = "+6588854320",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyAutherFour = new Auther()
            {
                Id = 4,
                Name = "Auther_four",
                Email = "auther@gmail.com",
                Phone = "+6599994320",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyAutherFive = new Auther()
            {
                Id = 5,
                Name = "Auther_Five",
                Email = "auther5@gmail.com",
                Phone = "+6588884320",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allAuthers = new List<Auther>();
            allAuthers.Add(dummyAutherOne);
            allAuthers.Add(dummyAutherTwo);
            allAuthers.Add(dummyAutherThree);
            allAuthers.Add(dummyAutherFour);
            allAuthers.Add(dummyAutherFive);

            return allAuthers;
        }

        public static IEnumerable<Price> LoadDummyPrices()
        {
            var dummyPriceOne = new Price()
            {
                PriceId = 1,
                BookPrice = 20,
                Discount = 10,
                StoreId = 1,
                BookId = 2,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyPriceTwo = new Price()
            {
                PriceId = 2,
                BookPrice = 18,
                Discount = 10,
                StoreId = 2,
                BookId = 2,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyPriceThree = new Price()
            {
                PriceId = 3,
                BookPrice = 25,
                Discount = 10,
                StoreId = 1,
                BookId = 3,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyPriceFour = new Price()
            {
                PriceId = 4,
                BookPrice = 26,
                Discount = 10,
                StoreId = 2,
                BookId = 3,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyPriceFive = new Price()
            {
                PriceId = 5,
                BookPrice = 32,
                Discount = 10,
                StoreId = 1,
                BookId = 4,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyPriceSix = new Price()
            {
                PriceId = 6,
                BookPrice = 38,
                Discount = 10,
                StoreId = 2,
                BookId = 4,
                CurrencyCode = "SGD",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allPrices = new List<Price>();
            allPrices.Add(dummyPriceOne);
            allPrices.Add(dummyPriceTwo);
            allPrices.Add(dummyPriceThree);
            allPrices.Add(dummyPriceFour);
            allPrices.Add(dummyPriceFive);
            allPrices.Add(dummyPriceSix);

            return allPrices;
        }

        public static IEnumerable<Stock> LoadDummyStocks()
        {
            var dummyStockOne = new Stock()
            {
                StockId = 1,
                Quantity = 10,
                StoreId = 1,
                BookId = 1,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStockTwo = new Stock()
            {
                StockId = 2,
                Quantity = 2,
                StoreId = 2,
                BookId = 1,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStockThree = new Stock()
            {
                StockId = 3,
                Quantity = 6,
                StoreId = 1,
                BookId = 2,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStockFour = new Stock()
            {
                StockId = 4,
                Quantity = 2,
                StoreId = 2,
                BookId = 2,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStockFive = new Stock()
            {
                StockId = 5,
                Quantity = 1,
                StoreId = 1,
                BookId = 3,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStockSix = new Stock()
            {
                StockId = 6,
                Quantity = 20,
                StoreId = 2,
                BookId = 3,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allStocks = new List<Stock>();
            allStocks.Add(dummyStockOne);
            allStocks.Add(dummyStockTwo);
            allStocks.Add(dummyStockThree);
            allStocks.Add(dummyStockFour);
            allStocks.Add(dummyStockFive);
            allStocks.Add(dummyStockSix);

            return allStocks;
        }

        public static IEnumerable<User> LoadDummyUsers()
        {
            var dummyUserOne = new User()
            {
                UserId = 1,
                UserName = "SystemAdmin",
                PhoneNumner = "+6543213089",
                Address = "blk 234,st12,Jurong East,Singapore,345213",
                BankAccountNumber = "23431223425",
                Role = UserRole.SystemAdmin.ToString(),
                EmailAddress = "admin@tyk.com",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyUserTwo = new User()
            {
                UserId = 2,
                UserName = "Customer1",
                PhoneNumner = "+6543213089",
                Address = "blk 124,st8,Jurong East,Singapore,349913",
                BankAccountNumber = "23431223425",
                Role = UserRole.Customer.ToString(),
                EmailAddress = "customer1@tyk.com",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyUserThree = new User()
            {
                UserId = 3,
                UserName = "Customer2",
                PhoneNumner = "+6543213089",
                Address = "blk 233,st10,Jurong East,Singapore,777213",
                BankAccountNumber = "78651223425",
                Role = UserRole.Customer.ToString(),
                EmailAddress = "customer2@tyk.com",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyUserFour = new User()
            {
                UserId = 4,
                UserName = "ShopOwner1",
                PhoneNumner = "+6577713089",
                Address = "blk 233,st10,Jurong East,Singapore,777213",
                BankAccountNumber = "78651223425",
                Role = UserRole.StoreOwner.ToString(),
                EmailAddress = "shopOwner1@tyk.com",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyUserFive = new User()
            {
                UserId = 5,
                UserName = "ShopOwner2",
                PhoneNumner = "+6588813089",
                Address = "blk 213,st10,Jurong East,Singapore,897213",
                BankAccountNumber = "88561223425",
                Role = UserRole.StoreOwner.ToString(),
                EmailAddress = "shopOwner2@ftk.com",
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allUsers = new List<User>();
            allUsers.Add(dummyUserOne);
            allUsers.Add(dummyUserTwo);
            allUsers.Add(dummyUserThree);
            allUsers.Add(dummyUserFour);
            allUsers.Add(dummyUserFive);

            return allUsers;
        }

        public static IEnumerable<Store> LoadDummyStore()
        {
            var dummyStoreOne = new Store()
            {
                StoreId = 1,
                OwnerUserId = 4,
                StoreName = "ABC-Store",
                PhoneNumner = "+6578542019",
                Address = "blk 666,st05,Jurong East,Singapore,909213",
                BankAccountNumber = "88561223425",
                EmailAddress = "shop1@tyk.com",
                //Some shops can be temporarily closed.
                IsActive = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyStoreTwo = new Store()
            {
                StoreId = 2,
                OwnerUserId = 5,
                StoreName = "XYZ-Store",
                PhoneNumner = "+6578542019",
                Address = "blk 564,st09,Jurong East,Singapore,101213",
                BankAccountNumber = "99961223425",
                EmailAddress = "shop2@tyk.com",
                //Some shops can be temporarily closed.
                IsActive = true,
                IsDeleted = false,
                CreatedUserId = 1,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 1,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allStores = new List<Store>();
            allStores.Add(dummyStoreOne);
            allStores.Add(dummyStoreTwo);

            return allStores;
        }

        public static IEnumerable<Order> LoadDummyOrders()
        {
            var dummyOrderOne = new Order()
            {
                OrderId = 1,
                BookId = 1,
                OrderStatus = OrderStatus.Delivered.ToString(),
                IsDeleted = false,
                CreatedUserId = 4,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 4,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyOrderTwo = new Order()
            {
                OrderId = 2,
                BookId = 1,
                OrderStatus = OrderStatus.Delivered.ToString(),
                IsDeleted = false,
                CreatedUserId = 5,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 5,
                LastUpdatedDateTime = DateTime.Now,
            };

            var dummyOrderThree = new Order()
            {
                OrderId = 3,
                BookId = 2,
                OrderStatus = OrderStatus.Paid.ToString(),
                IsDeleted = false,
                CreatedUserId = 4,
                CreatedDateTime = DateTime.Now,
                LastUpdatedUserId = 4,
                LastUpdatedDateTime = DateTime.Now,
            };

            var allOrders = new List<Order>();
            allOrders.Add(dummyOrderOne);
            allOrders.Add(dummyOrderTwo);
            allOrders.Add(dummyOrderThree);

            return allOrders;
        }

    }
}




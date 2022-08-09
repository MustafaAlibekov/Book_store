using DudarShop.Data.interfaces;
using DudarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DudarShop.Data.mocks
{
    public class mockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book { name = "Стив Лайонос - Криг", shortDesc = "", longDesc = "", img = "~/img/krieg.jpg", price = 480, isFavourite = true, available = true, Category = _categoryBooks.AllCAtegories.Last() },
                    new Book { name = "Роман с Data Science. Как монетизировать большие данные", shortDesc = "", longDesc = "", img = "~/img/C#.jpg", price = 480, isFavourite = true, available = true, Category = _categoryBooks.AllCAtegories.ElementAt(1) }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}

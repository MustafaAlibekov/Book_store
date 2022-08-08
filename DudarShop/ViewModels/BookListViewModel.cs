using DudarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DudarShop.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> AllBooks { get; set; }
        public string currCategory { get; set; }
    }
}

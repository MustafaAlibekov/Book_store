using DudarShop.Data.interfaces;
using DudarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DudarShop.Contollers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllbooks, IBooksCategory iBooksCat)
        {
            _allBooks = iAllbooks;
            _allCategories = iBooksCat;
        }

        public ViewResult List()
        {
            BookListViewModel obj = new BookListViewModel();
            obj.AllBooks = _allBooks.Books;
            obj.currCategory = "Книги";
            return View(obj);
        }

    }
}

using DudarShop.Data.interfaces;
using DudarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DudarShop.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCAtegories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Куллинария", desc = "книги о готовке"},
                    new Category{categoryName = "Программирование", desc = "книги о программировании"},
                    new Category{categoryName = "Технофентези", desc = "поджанр фэнтези, описывающий миры, где технологические достижения соседствуют с проявлениями магии"}
                };
            }
        }
    }
}

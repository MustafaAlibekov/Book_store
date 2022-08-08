using DudarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DudarShop.Data.interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCAtegories { get; }
    }
}

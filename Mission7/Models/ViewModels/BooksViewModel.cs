using System;
using System.Linq;

namespace Mission7.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}

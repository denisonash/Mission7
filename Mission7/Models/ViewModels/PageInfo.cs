using System;
namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }

        public int BooksPerPage { get; set; }

        public int CurrentPage { get; set; }

        // Figure out how many pages we need
        // Casting as different types
        public int TotalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}

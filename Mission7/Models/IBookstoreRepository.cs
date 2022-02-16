using System;
using System.Linq;

namespace Mission7.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }
    }
}

using System.Collections.Generic;
using MyKindleBooks.Domain;

namespace MyKindleBooks.DataAccess
{
    public interface IBookRepository
    {
        IList<Books> getAllBooks();
    }
}
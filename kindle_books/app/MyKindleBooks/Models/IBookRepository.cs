using System.Collections.Generic;

namespace MyKindleBooks.Models
{
    public interface IBookRepository
    {
        IList<Books> getAllBooks();
    }
}
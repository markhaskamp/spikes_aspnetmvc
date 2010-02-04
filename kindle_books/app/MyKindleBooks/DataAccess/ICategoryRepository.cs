using System.Collections.Generic;
using MyKindleBooks.Domain;

namespace MyKindleBooks.DataAccess
{
    public interface ICategoryRepository
    {
        IList<Category> GetAllCategoriesWithSubcategories();
    }
}
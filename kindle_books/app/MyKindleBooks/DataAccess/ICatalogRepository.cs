using System.Collections.Generic;
using MyKindleBooks.Domain;

namespace MyKindleBooks.DataAccess
{
    public interface ICatalogRepository
    {
        IList<Category> GetAllCategoriesWithSubcategories();
    }
}
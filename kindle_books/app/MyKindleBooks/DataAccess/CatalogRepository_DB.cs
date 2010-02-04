using System;
using System.Collections.Generic;
using MyKindleBooks.Domain;

namespace MyKindleBooks.DataAccess
{
    public class CatalogRepository_DB :ICatalogRepository
    {
        public IList<Category> GetAllCategoriesWithSubcategories() {
            throw new NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using MyKindleBooks.Domain;
using NHibernate;

namespace MyKindleBooks.DataAccess
{
    public interface ICategoryRepository
    {
        IList<Category> GetAllCategoriesWithSubcategories(ISession session);
        IList<Subcategory> GetAllSubcategories(ISession session);
    }
}
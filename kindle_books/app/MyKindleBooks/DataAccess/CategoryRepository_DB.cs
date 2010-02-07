using System.Collections.Generic;
using MyKindleBooks.Domain;
using NHibernate;

namespace MyKindleBooks.DataAccess
{
    public class CategoryRepository_DB : ICategoryRepository
    {

        public IList<Category> GetAllCategoriesWithSubcategories(ISession session) {
            return session.CreateQuery("FROM Category").List<Category>();
        }

    }
}
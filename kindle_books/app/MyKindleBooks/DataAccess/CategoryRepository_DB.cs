using System.Collections.Generic;
using MyKindleBooks.Domain;
using NHibernate;
using Ninject;

namespace MyKindleBooks.DataAccess
{
    public class CategoryRepository_DB : ICategoryRepository
    {
        private ISession _session;

        [Inject]
        public CategoryRepository_DB(ISession session) {
            _session = session;
        }

        public IList<Category> GetAllCategoriesWithSubcategories() {
            IQuery query = _session.CreateQuery("FROM Category");
            IList<Category> categories = query.List<Category>();
            return categories;
        }

    }
}
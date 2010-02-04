using System;
using System.Collections.Generic;
using System.Reflection;
using MyKindleBooks.Domain;
using NHibernate;
using NHibernate.Cfg;

namespace MyKindleBooks.DataAccess
{
    public class CategoryRepository_DB : ICategoryRepository
    {
        public IList<Category> GetAllCategoriesWithSubcategories() {
            IList<Category> categories = null;

            using (ISession session = OpenSession()) {
                IQuery query = session.CreateQuery("FROM Category");
                categories = query.List<Category>();
                return categories;
            }
        }

        private static ISessionFactory sessionFactory;
        static ISession OpenSession() {
            if (sessionFactory == null) {
                Configuration cfg = new Configuration();
                cfg.AddAssembly(Assembly.GetCallingAssembly());
                sessionFactory = cfg.BuildSessionFactory();
            }
            return sessionFactory.OpenSession();
        }
    }
}
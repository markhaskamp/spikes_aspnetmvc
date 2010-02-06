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

            using (ISession session = OpenSession()) {
                IQuery query = session.CreateQuery("FROM Category");
                IList<Category> categories = query.List<Category>();
                return categories;
            }
        }

        public IList<Subcategory> GetAllSubcategories() {
            using (ISession session = OpenSession()) {
                IQuery query = session.CreateQuery("From Subcategory");
                IList<Subcategory> subCategories = query.List<Subcategory>();
                return subCategories;
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
using System.Collections.Generic;
using System.Web.Mvc;
using MyKindleBooks.DataAccess;
using MyKindleBooks.Domain;
using NHibernate;

namespace MyKindleBooks.Models.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;
        private ISession _session;

        public CategoryController(ICategoryRepository categoryRepository) {
            this.categoryRepository = categoryRepository;
            _session = MvcApplication.SessionFactory.GetCurrentSession();
        }

        public ActionResult Index()
        {
            Category_ViewModel vm = new Category_ViewModel();

            // vm.AllCategories = categoryRepository.GetAllCategoriesWithSubcategories();
            IQuery query = _session.CreateQuery("FROM Category");
            IList<Category> categories = query.List<Category>();
            vm.AllCategories = categories;

//            vm.AllSubcategories = categoryRepository.GetAllSubcategories();
            query = _session.CreateQuery("From Subcategory");
            IList<Subcategory> subcategories = query.List<Subcategory>();
            vm.AllSubcategories = subcategories;

            ViewData.Model = vm;
            return View();
        }

    }
}

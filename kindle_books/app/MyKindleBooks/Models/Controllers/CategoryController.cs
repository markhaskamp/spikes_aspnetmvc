using System.Web.Mvc;
using MyKindleBooks.DataAccess;
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

            vm.AllCategories = categoryRepository.GetAllCategoriesWithSubcategories(_session);
            vm.AllSubcategories = categoryRepository.GetAllSubcategories(_session);

            ViewData.Model = vm;
            return View();
        }

    }
}

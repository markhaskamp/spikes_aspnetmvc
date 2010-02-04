using System.Web.Mvc;
using MyKindleBooks.DataAccess;

namespace MyKindleBooks.Models.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) {
            this.categoryRepository = categoryRepository;
        }

        public ActionResult Index()
        {
            Category_ViewModel vm = new Category_ViewModel();
            vm.AllCategories = categoryRepository.GetAllCategoriesWithSubcategories();
            ViewData.Model = vm;
            return View();
        }

    }
}

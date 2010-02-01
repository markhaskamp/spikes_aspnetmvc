using System.Linq;
using System.Web.Mvc;

namespace MyKindleBooks.Models.Controllers
{
    public class BookController : Controller
    {
        Book_ViewModel vm = new Book_ViewModel();
        
        //
        // GET: /Book/
        public ActionResult Index()
        {
            vm.AllBooks = BookRepository.SampleData();
            ViewData.Model = vm;
            return View();
        }

        [AcceptVerbs("Post")]
        public ActionResult Index(string authorName) {
            var allBooks = BookRepository.SampleData();

            if (authorName.Trim().Length == 0) {
                vm.showAuthorLabel = false;
                vm.AllBooks = allBooks;
            }
            else {
                vm.authorLabel = authorName;
                vm.showAuthorLabel = true;

//                var result = from b in allBooks
//                             where b.Author == authorName
//                             select b;
//                var result = allBooks.Where(b => b.Author == authorName);
                vm.AllBooks  = allBooks.Where(b => b.Author == authorName).ToList();
            }

            ViewData.Model = vm;
            return View();
        }
    }
}

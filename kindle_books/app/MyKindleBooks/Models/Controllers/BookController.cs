using System.Linq;
using System.Web.Mvc;

namespace MyKindleBooks.Models.Controllers
{
    public class BookController : Controller
    {

        Book_ViewModel vm = new Book_ViewModel();

        private IBookRepository bookRepository;
        
        public BookController(IBookRepository bookRepository) {
            this.bookRepository = bookRepository;
        }
        //
        // GET: /Book/
        public ActionResult Index()
        {
            vm.AllBooks = bookRepository.getAllBooks();
            ViewData.Model = vm;
            return View();
        }

        [AcceptVerbs("Post")]
        public ActionResult Index(string authorName) {
            var allBooks = bookRepository.getAllBooks();

            if (authorName.Trim().Length == 0) {
                vm.showAuthorLabel = false;
                vm.AllBooks = allBooks;
            }
            else {
                vm.authorLabel = authorName;
                vm.showAuthorLabel = true;

                vm.AllBooks  = allBooks.Where(b => b.Author == authorName).ToList();
            }

            ViewData.Model = vm;
            return View();
        }
    }
}

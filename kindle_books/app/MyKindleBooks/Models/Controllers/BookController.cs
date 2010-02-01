using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

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
            vm.authorLabel = authorName;
            vm.showAuthorLabel = true;
            var allBooks = BookRepository.SampleData();

            var result = from b in allBooks
                          where b.Author == authorName
                          select b;

            foreach (var book in result) {
                vm.AllBooks.Add(book);
            }

            ViewData.Model = vm;
            return View();
        }

    }
}

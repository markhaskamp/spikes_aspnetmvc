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

    }
}

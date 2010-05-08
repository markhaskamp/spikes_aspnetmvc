using System.Web.Mvc;

namespace NHaml_Spike.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index() {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About() {
            return View();
        }

        public ActionResult Test() {
            return View();
        }
    }
}

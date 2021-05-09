using System.Web.Mvc;

namespace MovieLibrary.Controllers
{
    public class Customers : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System.Web.Mvc;

namespace Introducao01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

       
    }
}
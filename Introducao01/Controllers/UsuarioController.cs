using Introducao01.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace Introducao01.Controllers
{
    public class UsuarioController : Controller
    {
       

        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View();
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Jose",
                "Marcio",
                "Livia"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
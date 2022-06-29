using Introducao01.Models;
using System.Web.Mvc;

namespace Introducao01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "José Márcio",
                Tipo = "Administrador"

            };

            // ViewData["PessoaId"] = pessoa.PessoaId;
            // ViewData["Nome"] = pessoa.Nome;
            // ViewData["Tipo"] = pessoa.Tipo;


            //ViewBag.id = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo;

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {


            return View(pessoa);
        }



    }
}
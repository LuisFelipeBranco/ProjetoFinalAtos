using Microsoft.AspNetCore.Mvc;
using TeplanConsultoria.Models;
using TeplanConsultoria.Repositorio;

namespace TeplanConsultoria.Controllers
{
    public class PropriedadeController : Controller
    {
        private readonly IPropriedadeRepositorio _propriedadeRepositorio;
        public PropriedadeController(IPropriedadeRepositorio propriedadeRepositorio)
        {
            _propriedadeRepositorio = propriedadeRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(PropriedadeModel propriedade) {
            _propriedadeRepositorio.Adicionar(propriedade);
            return RedirectToAction("Index");
        }

    }
}

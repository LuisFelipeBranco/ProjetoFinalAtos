using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace TeplanConsultoria.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "Retorno de mensagem no HelloWorldController";
        }
        public IActionResult Welcome(string nome = "Luis Felipe Branco", int numTimes = 10) {
            ViewData["Message"] = "Hello " + nome;
            ViewData["NumTimes"] = numTimes;
            ViewData["Teste"] = "Apenas um texto de teste!!";
            return View();
        }

        /*public string welcome(string nome, int qtd) {
            return HtmlEncoder.Default.Encode($"Ola {nome}, seja bem vindo pela: {qtd} vez");
        }*/
        /*public string Welcome(string nome, int ID = 1) {
            return HtmlEncoder.Default.Encode($"Ola: {nome}, ID: {ID}");
        }*/


    }
}

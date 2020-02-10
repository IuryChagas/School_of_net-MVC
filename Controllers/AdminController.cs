using System;
using Microsoft.AspNetCore.Mvc;

namespace School_of_net_MVC.Controllers {

    [Route("painel/admin")]
    public class AdminController : Controller {

        [HttpGet("principal/{number:int?}/{name}")]
        public IActionResult Index(int number, string name){
            return Content($"Teste - customizando valores em rotas\nNúmero informado: {number}\nNome: {name}");
        }

        [HttpGet("son")]
        public IActionResult SchoolOfNet(){
            var nome = Request.Query["nome"];
            return Content($"Testando funcionamento de Controllers em ASP.NET Core\nNome: {nome}");
        }

        [HttpGet("Newpage")]
        public IActionResult Visualizar(){
            return View();
        }
    }
}
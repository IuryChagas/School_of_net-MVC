using System;
using Microsoft.AspNetCore.Mvc;

namespace School_of_net_MVC.Controllers {

    [Route("painel/admin")]
    public class AdminController : Controller {

        [HttpGet("principal/{number:int}")]
        public IActionResult Index(int number){
            return Content($"Teste - customizando valores em rotas\nnúmero informado: {number}");
        }

        [HttpGet("son")]
        public IActionResult SchoolOfNet(){
            return Content("Testando funcionamento de Controllers em ASP.NET Core");
        }
    }
}
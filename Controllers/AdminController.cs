using System;
using Microsoft.AspNetCore.Mvc;

namespace School_of_net_MVC.Controllers {

    [Route("painel/admin")] // Para mapear rotas customizadas!
    public class AdminController : Controller {

        [HttpGet("principal/{name}")] //  essas rotas estão em mesmo nível de hierarquia
        public IActionResult Index(string name){
            return Content("Teste - criando controllers\nNome: "+name);
        }

        [HttpGet("son")] // é possível criar alias customizadas para setar rotas
        public IActionResult SchoolOfNet(){
            return Content("Testando funcionamento de Controllers em ASP.NET Core");
        }
    }
}
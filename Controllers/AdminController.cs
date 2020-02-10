using System;
using Microsoft.AspNetCore.Mvc;

namespace School_of_net_MVC.Controllers {

    [Route("nova/rota/caminho")]
    public class AdminController : Controller {

        [HttpGet("criando")]
        public IActionResult Index(){
            return Content("Teste - criando controllers");
        }

        [HttpGet("subaction")] // é possível criar alias customizadas para setar rotas
        [HttpGet("novasubaction")] //  também é possível criar mais de uma alias para uma mesma subpage
        public IActionResult SchoolOfNet(){
            return Content("Testando funcionamento de Controllers em ASP.NET Core");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School_of_net_MVC.Database;
using School_of_net_MVC.Models;

namespace School_of_net_MVC.Controllers {
    public class HomeController : Controller {

        private readonly ApplicationDBContext database;

        public HomeController(ApplicationDBContext database){
            this.database = database;
        }

        // private readonly ILogger<HomeController> _logger;

        // public HomeController (ILogger<HomeController> logger) {
        //     _logger = logger;
        // }

        public IActionResult Index () {
            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        public IActionResult Teste(){
            Categoria c1 = new Categoria();
                c1.Nome = "Comercial";
            Categoria c2 = new Categoria();
                c2.Nome = "Marketing";
            Categoria c3 = new Categoria();
                c3.Nome = "Support";
            Categoria c4 = new Categoria();
                c4.Nome = "Juridico";

            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria.Add(c1);
            listaCategoria.Add(c2);
            listaCategoria.Add(c3);
            listaCategoria.Add(c4);

            database.AddRange(listaCategoria);
            database.SaveChanges();

            return Content("Dados Salvos!");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
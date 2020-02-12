using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using School_of_net_MVC.Database;
using School_of_net_MVC.Models;

namespace School_of_net_MVC.Controllers {
    public class HomeController : Controller {

        private readonly ApplicationDBContext database;

        public HomeController(ApplicationDBContext database){
            this.database = database;
        }
        public IActionResult Index () {
            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        public IActionResult Teste(){
            // Categoria c1 = new Categoria();
            //     c1.Nome = "Comercial";
            // Categoria c2 = new Categoria();
            //     c2.Nome = "Marketing";
            // Categoria c3 = new Categoria();
            //     c3.Nome = "Support";
            // Categoria c4 = new Categoria();
            //     c4.Nome = "Juridico";

            // List<Categoria> listCat = new List<Categoria>();
            // listCat.Add(c1);
            // listCat.Add(c2);
            // listCat.Add(c3);
            // listCat.Add(c4);

            // database.AddRange(listCat);
            // database.SaveChanges();

            var listaCategorias = database.Categorias.Where(cat => cat.Id  < 3).ToList();

            Console.WriteLine("=================== Setores ===================");

                listaCategorias.ForEach(categoria => {
                    Console.WriteLine(categoria.ToString());
                });

            Console.WriteLine("===============================================");
            return Content("Dados Salvos!");
        }

        public IActionResult Relacionamento(){

            // Produto produto0 = new Produto();
            // produto0.Nome = "Notebook";
            // produto0.Categoria = database.Categorias.First(c => c.Id == 1);

            // Produto produto1 = new Produto();
            // produto1.Nome = "SSD";
            // produto1.Categoria = database.Categorias.First(c => c.Id == 1);

            // Produto produto2 = new Produto();
            // produto2.Nome = "Teclado";
            // produto2.Categoria = database.Categorias.First(c => c.Id == 2);

            // database.Add(produto0);
            // database.Add(produto1);
            // database.Add(produto2);

            // database.SaveChanges();

            var listaDeProdutos = database.Produtos.Include(produto => produto.Categoria).ToList();

            listaDeProdutos.ForEach(produto => {
                Console.WriteLine(produto.ToString());
            });

            return Content("Relacionamento");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System;
using Microsoft.AspNetCore.Mvc;
using School_of_net_MVC.Models;
using System.Globalization;
using School_of_net_MVC.Database;
using System.Linq;

namespace School_of_net_MVC.Controllers {
    public class FuncionariosController : Controller {

        private readonly ApplicationDBContext database;

        public FuncionariosController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Index(){
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            database.Funcionarios.Add(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
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

        public IActionResult Editar(int id){
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id); 
            return View("Cadastrar", funcionario);
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            if(funcionario.Id == 0){
                database.Funcionarios.Add(funcionario);
            }else{
                Funcionario funcionarioDoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                funcionarioDoBanco.Nome = funcionario.Nome;
                funcionarioDoBanco.Cpf = funcionario.Cpf;
                funcionario.Salario = funcionario.Salario;
            }
            
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
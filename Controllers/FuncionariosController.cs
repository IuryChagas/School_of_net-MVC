using System;
using Microsoft.AspNetCore.Mvc;
using School_of_net_MVC.Models;
using System.Globalization;

namespace School_of_net_MVC.Controllers {
    public class FuncionariosController : Controller {
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            return Content($"Nome: {funcionario.Nome}\nSalário: {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}\nCPF: {funcionario.Cpf}");
        }
    }
}
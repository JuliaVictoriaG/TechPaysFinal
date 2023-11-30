using Microsoft.AspNetCore.Mvc;
using TechPays.Models;

namespace TechPays.Controllers
{
    public class FolhaDePagamentoController : Controller
    {
       
        
        public IActionResult Index()
        {
            return View("GerarFolha");
        }
        [HttpPost]
        public IActionResult CalcularSalario(FuncionarioModel funcionario)
        {
            // Cálculos
            decimal func_salario_liquido = funcionario.func_salario_bruto - funcionario.func_vale_transporte - 
                funcionario.func_fgts  - funcionario.func_inss;

            funcionario.func_salario_liquido = func_salario_liquido;

            funcionario.GerarFolhaPagamentoPDF();
            return RedirectToAction("Index", "Home");
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using TechPays.Models;

namespace TechPays.Controllers
{
    public class FolhaDePagamentoController : Controller
    {
        private FuncionarioModel _funcionarioModel;
        public FolhaDePagamentoController(FuncionarioModel funcionarioModel)
        {
            _funcionarioModel = funcionarioModel;
        }
        public IActionResult Index()
        {
            return View();
        }

        public void CalcularSalario(FuncionarioModel funcionario)
        {
            // Cálculos
            decimal func_salario_liquido = funcionario.func_salario_bruto - funcionario.func_vale_transporte - 
                funcionario.func_fgts  - funcionario.func_inss;

            funcionario.func_salario_liquido = func_salario_liquido;
        }


    }
}

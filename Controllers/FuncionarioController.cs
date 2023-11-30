using Microsoft.AspNetCore.Mvc;
using TechPays.Data;
using TechPays.Filters;
using TechPays.Helper;
using TechPays.Models;
using TechPays.Repository;

namespace TechPays.Controllers
{
    [PaginaParaUsuarioLogado]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly ISessao _sessao;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository,
                                 ISessao sessao)
        {
            _funcionarioRepository = funcionarioRepository;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
            List<FuncionarioModel> funcionario = _funcionarioRepository.BuscarTodos(usuarioLogado.Id);

            return View(funcionario);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepository.BuscarPorID(id);
            return View(funcionario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepository.BuscarPorID(id);
            return View(funcionario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _funcionarioRepository.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Contato apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos cadastrar seu contato, tente novamante!";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        //public FuncionarioModel CalcularSalario(FuncionarioModel funcionario)
        //{
        //    double salarioCalculado = funcionario.CalcularSalario();

        //    funcionario.func_salario_bruto = salarioCalculado;
        //    return funcionario;
        //}

        [HttpPost]
        public IActionResult Cadastrar(FuncionarioModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                    funcionario.func_usuario = usuarioLogado.Id;

                    funcionario = _funcionarioRepository.Adicionar(funcionario);

                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(funcionario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(FuncionarioModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                    funcionario.func_usuario = usuarioLogado.Id;

                    funcionario = _funcionarioRepository.Atualizar(funcionario);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(funcionario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}

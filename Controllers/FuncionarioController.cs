using Microsoft.AspNetCore.Mvc;
using System.Data;
using TechPays.Data;
using TechPays.Filters;
using TechPays.Helper;
using TechPays.Models;
using TechPays.Repository;

namespace TechPays.Controllers
{
    public class FuncionarioController : Controller
    {
        readonly private ApplicationDbContext _db;

        public FuncionarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<FuncionarioModel> funcionarios = _db.Funcionarios;
            return View(funcionarios);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FuncionarioModel funcionario = _db.Funcionarios.FirstOrDefault(x => x.func_id == id);

            if (funcionario == null)
            {
                return NotFound();
            }


            return View(funcionario);
        }

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FuncionarioModel funcionario = _db.Funcionarios.FirstOrDefault(x => x.func_id == id);

            if (funcionario == null)
            {
                return NotFound();
            }


            return View(funcionario);

        }
    }
}


       

    //    private DataTable GetDados()
    //    {

    //        DataTable dataTable = new DataTable();

    //        dataTable.TableName = "Dados emprestimos";


    //        DataTable dataTable = new DataTable();

    //        dataTable.TableName = "Dados empréstimos";

    //        dataTable.Columns.Add("Recebedor", typeof(string));
    //        dataTable.Columns.Add("Fornecedor", typeof(string));
    //        dataTable.Columns.Add("Livro", typeof(string));

    //        dataTable.Columns.Add("Data última atualização", typeof(DateTime));

    //        var dados = _db.Emprestimos.ToList();

    //        if (dados.Count > 0)

    //        dataTable.Columns.Add("Data empréstimo", typeof(DateTime));

    //        var dados = _db.Emprestimos.ToList();

    //        if(dados.Count > 0)

    //        {
    //            dados.ForEach(emprestimo =>
    //            {
    //                dataTable.Rows.Add(emprestimo.Recebedor, emprestimo.Fornecedor, emprestimo.LivroEmprestado, emprestimo.DataEmprestimo);
    //            });
    //        }

    //        return dataTable;


    //    }


    //    }




    //    [HttpPost]
    //    public IActionResult Cadastrar(EmprestimosModel emprestimo)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            emprestimo.DataEmprestimo = DateTime.Now;

    //            _db.Emprestimos.Add(emprestimo);
    //            _db.SaveChanges();
    //            TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

    //            return RedirectToAction("Index");
    //        }

    //        return View();

    //    }

    //    [HttpPost]
    //    public IActionResult Editar(EmprestimosModel emprestimo)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var emprestimoDB = _db.Emprestimos.Find(emprestimo.Id);


    //            emprestimoDB.LivroEmprestado = emprestimo.LivroEmprestado;
    //            emprestimoDB.Recebedor = emprestimo.Recebedor;
    //            emprestimoDB.Fornecedor = emprestimo.Fornecedor;

    //            emprestimoDB.Fornecedor = emprestimo.Fornecedor;
    //            emprestimoDB.Recebedor = emprestimo.Recebedor;
    //            emprestimoDB.LivroEmprestado = emprestimo.LivroEmprestado;


    //            _db.Emprestimos.Update(emprestimoDB);
    //            _db.SaveChanges();

    //            TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

    //            return RedirectToAction("Index");
    //        }

    //        TempData["MensagemErro"] = "Ocorreu algum erro no momento da edição!";
    //        return View(emprestimo);
    //    }

    //    [HttpPost]
    //    public IActionResult Excluir(EmprestimosModel emprestimo)
    //    {
    //        if (emprestimo == null)
    //        {
    //            return NotFound();
    //        }

    //        _db.Emprestimos.Remove(emprestimo);
    //        _db.SaveChanges();
    //        TempData["MensagemSucesso"] = "Remoção realizada com sucesso!";
    //        return RedirectToAction("Index");

    //    }



    //}




   





































//
    //[PaginaParaUsuarioLogado]
    //public class FuncionarioController : Controller
    //{
    //    private readonly IFuncionarioRepository _funcionarioRepository;
    //    private readonly ISessao _sessao;

    //    public FuncionarioController(IFuncionarioRepository funcionarioRepository,
    //                             ISessao sessao)
    //    {
    //        _funcionarioRepository = funcionarioRepository;
    //        _sessao = sessao;
    //    }

    //    public IActionResult Index()
    //    {
    //        UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
    //        List<FuncionarioModel> funcionario = _funcionarioRepository.BuscarTodos(usuarioLogado.Id);

    //        return View(funcionario);
    //    }

    //    public IActionResult Cadastrar()
    //    {
    //        return View();
    //    }

    //    public IActionResult Editar(int id)
    //    {
    //        FuncionarioModel funcionario = _funcionarioRepository.BuscarPorID(id);
    //        return View(funcionario);
    //    }

    //    public IActionResult ApagarConfirmacao(int id)
    //    {
    //        FuncionarioModel funcionario = _funcionarioRepository.BuscarPorID(id);
    //        return View(funcionario);
    //    }

    //    public IActionResult Apagar(int id)
    //    {
    //        try
    //        {
    //            bool apagado = _funcionarioRepository.Apagar(id);

    //            if (apagado) TempData["MensagemSucesso"] = "Contato apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos cadastrar seu contato, tente novamante!";
    //            return RedirectToAction("Index");
    //        }
    //        catch (Exception erro)
    //        {
    //            TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, tente novamante, detalhe do erro: {erro.Message}";
    //            return RedirectToAction("Index");
    //        }
    //    }

    //    //public FuncionarioModel CalcularSalario(FuncionarioModel funcionario)
    //    //{
    //    //    double salarioCalculado = funcionario.CalcularSalario();

    //    //    funcionario.func_salario_bruto = salarioCalculado;
    //    //    return funcionario;
    //    //}

    //    [HttpPost]
    //    public IActionResult Cadastrar(FuncionarioModel funcionario)
    //    {
    //        try
    //        {
    //            if (ModelState.IsValid)
    //            {
    //                UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
    //                funcionario.func_usuario = usuarioLogado.Id;

    //                funcionario = _funcionarioRepository.Adicionar(funcionario);

    //                TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
    //                return RedirectToAction("Index");
    //            }

    //            return View(funcionario);
    //        }
    //        catch (Exception erro)
    //        {
    //            TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamante, detalhe do erro: {erro.Message}";
    //            return RedirectToAction("Index");
    //        }
    //    }

    //    [HttpPost]
    //    public IActionResult Editar(FuncionarioModel funcionario)
    //    {
    //        try
    //        {
    //            if (ModelState.IsValid)
    //            {
    //                UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
    //                funcionario.func_usuario = usuarioLogado.Id;

    //                funcionario = _funcionarioRepository.Atualizar(funcionario);
    //                TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
    //                return RedirectToAction("Index");
    //            }

    //            return View(funcionario);
    //        }
    //        catch (Exception erro)
    //        {
    //            TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamante, detalhe do erro: {erro.Message}";
    //            return RedirectToAction("Index");
    //        }
    //    }

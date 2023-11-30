using Microsoft.AspNetCore.Mvc;
using TechPays.Models;
using System;
using System.Collections.Generic;
using TechPays.Repository;
using TechPays.Filters;

namespace TechPays.Controllers
{

    [PaginaRestritaAdm]
    public class UsuarioController : Controller
    {

       
       

            private readonly IUsuarioRepository _usuarioRepository;
            private readonly IFuncionarioRepository _funcionarioRepository;

            public UsuarioController(IUsuarioRepository usuarioRepository,
                                     IFuncionarioRepository contatoRepository)
            {
                _usuarioRepository = usuarioRepository;
                _funcionarioRepository = contatoRepository;
            }

            public IActionResult Index()
            {
                //List<UsuarioModel> usuarios = _usuarioRepository.BuscarTodos();

                return View();
            }

            public IActionResult Cadastrar()
            {
                return View();
            }

            public IActionResult Editar(int id)
            {
                UsuarioModel usuario = _usuarioRepository.BuscarPorID(id);
                return View(usuario);
            }

            public IActionResult ApagarConfirmacao(int id)
            {
                UsuarioModel usuario = _usuarioRepository.BuscarPorID(id);
                return View(usuario);
            }

            public IActionResult Apagar(int id)
            {
                try
                {
                    bool apagado = _usuarioRepository.Apagar(id);

                    if (apagado) TempData["MensagemSucesso"] = "Usuário apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos apagar seu usuário, tente novamante!";
                    return RedirectToAction("Index");
                }
                catch (Exception erro)
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu usuário, tente novamante, detalhe do erro: {erro.Message}";
                    return RedirectToAction("Index");
                }
            }

            public IActionResult ListarContatosPorUsuarioId(int id)
            {
                List<FuncionarioModel> funcionarios = _funcionarioRepository.BuscarTodos(id);
                return PartialView("_ContatosUsuario", funcionarios);
            }

            [HttpPost]
            public IActionResult Cadastrar(UsuarioModel usuario)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        usuario = _usuarioRepository.Adicionar(usuario);

                        TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                        return RedirectToAction("Index");
                    }

                    return View(usuario);
                }
                catch (Exception erro)
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu usuário, tente novamante, detalhe do erro: {erro.Message}";
                    return RedirectToAction("Index");
                }
            }

          
            public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenhaModel)
            {
                try
                {
                    UsuarioModel usuario = null;

                    if (ModelState.IsValid)
                    {
                        usuario = new UsuarioModel()
                        {
                            Id = usuarioSemSenhaModel.Id,
                            Nome = usuarioSemSenhaModel.Nome,
                            Login = usuarioSemSenhaModel.Login,
                            Email = usuarioSemSenhaModel.Email,
                            Perfil = (Enumeration.PerfilEnum)usuarioSemSenhaModel.Perfil
                        };

                        usuario = _usuarioRepository.Atualizar(usuario);
                        TempData["MensagemSucesso"] = "Usuário alterado com sucesso!";
                        return RedirectToAction("Index");
                    }

                    return View(usuario);
                }
                catch (Exception erro)
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu usuário, tente novamante, detalhe do erro: {erro.Message}";
                    return RedirectToAction("Index");
                }
            }
        }
    }



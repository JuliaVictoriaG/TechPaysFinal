using Microsoft.AspNetCore.Mvc;
using TechPays.Data;
using TechPays.Models;

namespace TechPays.Controllers
{
    public class EmpresaController : Controller
    {

        private readonly ApplicationDbContext  _db;
          

     public EmpresaController(ApplicationDbContext db)
        {
            _db = db;
                
        }
      
        public IActionResult Index()
        {
            IEnumerable<EmpresaModel> empresas = _db.Empresa;
            return View(empresas);
        }


        public IActionResult Cadastrar(EmpresaModel empresa)
        {
            if (ModelState.IsValid)
            {
               

                _db.Empresa.Add(empresa);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}


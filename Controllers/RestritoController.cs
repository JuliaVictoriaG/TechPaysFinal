using Microsoft.AspNetCore.Mvc;
using TechPays.Filters;

namespace TechPays.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

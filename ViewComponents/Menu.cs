using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TechPays.Models;
using TechPays.Enumeration;

namespace TechPays.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            var usuarioFake = new UsuarioModel()
            {
                Nome = "Usuario",
                Email ="usuario@gmail.com",
                Perfil = PerfilEnum.Admin,
            };
            if (string.IsNullOrEmpty(sessaoUsuario)) return View(usuarioFake);

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            return View(usuario);
        }
    }
}

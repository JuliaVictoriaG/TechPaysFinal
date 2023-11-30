﻿using TechPays.Models;

namespace TechPays.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();
    }
}

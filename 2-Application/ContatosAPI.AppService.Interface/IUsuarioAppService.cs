using ContatosAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ContatosAPI.AppService.Interface
{
    public interface IUsuarioAppService
    {
        List<Contato> VisualizarContatos(Guid IdUsuario);
        Usuario AdicionarUsuario(string NomeUsuario);
        Usuario VisualizarUsuario(Guid IdUsuario);
        Guid RemoverUsuario(Guid IdUsuario);

    }
}

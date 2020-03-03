using ContatosAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ContatoAPI.Domain.Interface
{
    public interface IUsuarioService
    {
        List<Contato> VisualizarContatos(Guid IdUsuario);
        Usuario AdicionarUsuario(Usuario UsuarioA);
        Usuario VisualizarUsuario(Guid IdUsuario);
        Guid RemoverUsuario(Guid IdUsuario);
    }
}

using ContatosAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ContatosAPI.Infra.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Contato AdicionarContato(Guid IdUsuario, Contato ContatoA);
        Guid RemoverContato(Guid IdUsuario, Guid IdContato);
        Contato EditarContato(Guid IdUsuario, Contato ContatoA);
        Contato VisualizarContato(Guid IdUsuario, Guid IdContato);
        List<Contato> VisualizarContatos(Guid IdUsuario);
        Usuario VisualizarUsuario(Guid IdUsuario);
        Usuario AdicionarUsuario(Usuario UsuarioA);
        Guid RemoverUsuario(Guid IdUsuario);

    }
}

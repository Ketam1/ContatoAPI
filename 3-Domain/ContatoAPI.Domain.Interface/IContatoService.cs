using ContatosAPI.Domain.Modelos;
using System;
using System.Web.Mvc;

namespace ContatoAPI.Domain.Interface
{
    public interface IContatoService
    {
        Contato AdicionarContato(Guid IdUsuario, Contato ContatoA);
        Guid RemoverContato(Guid IdUsuario, Guid IdContato);
        Contato EditarContato(Guid IdUsuario, Contato ContatoA);
        Contato VisualizarContato(Guid IdUsuario, Guid IdContato);
    }
}

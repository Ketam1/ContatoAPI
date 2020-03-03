using ContatosAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ContatosAPI.AppService.Interface
{
    public interface IContatoAppService
    {
        Contato AdicionarContato(Guid IdUsuario, Contato ContatoA);
        Guid RemoverContato(Guid IdUsuario, Guid IdContato);
        Contato EditarContato(Guid IdUsuario, Contato ContatoA);
        Contato VisualizarContato(Guid IdUsuario, Guid IdContato);
    }
}

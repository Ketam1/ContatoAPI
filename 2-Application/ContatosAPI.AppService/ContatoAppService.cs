using System;
using ContatoAPI.Domain.Interface;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain.Modelos;

namespace ContatosAPI.AppService
{
    public class ContatoAppService : IContatoAppService
    {

        private readonly IContatoService _ContatoService;

        public ContatoAppService(IContatoService contatoService)
        {
            _ContatoService = contatoService;
        }

        public Contato AdicionarContato(Guid IdUsuario, Contato ContatoA)
        {
            return _ContatoService.AdicionarContato(IdUsuario, ContatoA);
        }

        public Contato EditarContato(Guid IdUsuario, Contato ContatoA)
        {
            return _ContatoService.EditarContato(IdUsuario, ContatoA);
        }

        public Guid RemoverContato(Guid IdUsuario, Guid IdContato)
        {
            return _ContatoService.RemoverContato(IdUsuario, IdContato);
        }

        public Contato VisualizarContato(Guid IdUsuario, Guid IdContato)
        {
            return _ContatoService.VisualizarContato(IdUsuario, IdContato);
        }
    }
}

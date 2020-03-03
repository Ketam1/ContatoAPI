using System;
using System.Web.Mvc;
using ContatoAPI.Domain.Interface;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository.Interface;

namespace ContatosAPI.Domain
{
    public class ContatoService : IContatoService
    {

        private readonly IUsuarioRepository _UsuarioRepository;

        public ContatoService(IUsuarioRepository usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

        public Contato AdicionarContato(Guid IdUsuario, Contato ContatoA)
        {
            ContatoA.IdContato = Guid.NewGuid();
            return _UsuarioRepository.AdicionarContato(IdUsuario, ContatoA);
        }

        public Contato EditarContato(Guid IdUsuario, Contato ContatoA) 
        { 
            return _UsuarioRepository.EditarContato(IdUsuario, ContatoA);
        }

        public Guid RemoverContato(Guid IdUsuario, Guid IdContato)
        {
            return _UsuarioRepository.RemoverContato(IdUsuario, IdContato);
        }

        public Contato VisualizarContato(Guid IdUsuario, Guid IdContato)
        {
            return _UsuarioRepository.VisualizarContato(IdUsuario, IdContato);
        }
    }
}

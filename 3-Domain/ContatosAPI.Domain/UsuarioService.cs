using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using ContatoAPI.Domain.Interface;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository.Interface;

namespace ContatosAPI.Domain
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _UsuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

        public Usuario AdicionarUsuario(Usuario UsuarioA)
        {
            return _UsuarioRepository.AdicionarUsuario(UsuarioA);
        }

        public Guid RemoverUsuario(Guid IdUsuario)
        {
            return _UsuarioRepository.RemoverUsuario(IdUsuario);
        }

        public List<Contato> VisualizarContatos(Guid IdUsuario)
        {
            return _UsuarioRepository.VisualizarContatos(IdUsuario);
        }

        public Usuario VisualizarUsuario(Guid IdUsuario)
        {
            return _UsuarioRepository.VisualizarUsuario(IdUsuario);
        }
    }
}

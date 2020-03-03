using ContatoAPI.Domain.Interface;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService
{
    public class UsuarioAppService : IUsuarioAppService
    {

        private readonly IUsuarioService _UsuarioService;

        public UsuarioAppService( IUsuarioService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }

        public Usuario AdicionarUsuario(string NomeUsuario)
        {
            Usuario UsuarioA = new Usuario(NomeUsuario);

            return _UsuarioService.AdicionarUsuario(UsuarioA);
        }

        public Guid RemoverUsuario(Guid IdUsuario)
        {
            return _UsuarioService.RemoverUsuario(IdUsuario);
        }

        public List<Contato> VisualizarContatos(Guid IdUsuario)
        {
            return _UsuarioService.VisualizarContatos(IdUsuario);
        }

        public Usuario VisualizarUsuario(Guid IdUsuario)
        {
            return _UsuarioService.VisualizarUsuario(IdUsuario);
        }
    }
}

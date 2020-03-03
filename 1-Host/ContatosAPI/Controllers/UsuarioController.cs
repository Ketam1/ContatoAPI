using System;
using ContatoAPI.ApiErros;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContatosAPI.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService UsuarioAppService)
        {
            _usuarioAppService = UsuarioAppService;
        }

        [HttpPost, Route("adicionar")]
        public IActionResult AdicionarUsuario([FromBody]string NomeUsuario)
        {
            try
            {
                return Ok(_usuarioAppService.AdicionarUsuario(NomeUsuario));
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
            
        }

        [HttpPost, Route("remover")]
        public IActionResult RemoverUsuario(Guid IdUsuario)
        {
            try
            {
                return Ok(_usuarioAppService.RemoverUsuario(IdUsuario));
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
             
        }

        [HttpGet, Route("visualizarcontatos/{IdUsuario}")]
        public IActionResult VisualizarContatos(Guid IdUsuario)
        {
            try
            {
                return Ok(_usuarioAppService.VisualizarContatos(IdUsuario));
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
        }

        [HttpGet, Route("visualizar/{IdUsuario}")]
        public IActionResult VisualizarUsuario(Guid IdUsuario)
        {
            try
            {
                return Ok(_usuarioAppService.VisualizarUsuario(IdUsuario));
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
        }

    }
}

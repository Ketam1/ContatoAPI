using System;
using Microsoft.AspNetCore.Mvc;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain.Modelos;
using Microsoft.AspNetCore.Http;
using ContatoAPI.ApiErros;

namespace ContatosAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/contato")]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoAppService _contatoAppService;
        
        public ContatoController(IContatoAppService contatoAppService)
        {
            _contatoAppService = contatoAppService;
        }

        [HttpPost, Route("adicionar/{IdUsuario}")]
        public IActionResult AdicionarContato(Guid IdUsuario, [FromBody]Contato ContatoA)
        {
            try
            {
                return Ok(_contatoAppService.AdicionarContato(IdUsuario, ContatoA));
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
            
        }

        [HttpPut, Route("editar/{IdUsuario}")]
        public IActionResult EditarContato(Guid IdUsuario, [FromBody]Contato ContatoA)
        {
            try
            {
                return Ok(_contatoAppService.EditarContato(IdUsuario, ContatoA));
            }
            catch(Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
                
        }


        [HttpDelete, Route("remover/{IdUsuario}")]
        public IActionResult RemoverContato(Guid IdUsuario, [FromBody]Guid IdContato)
        {
            try
            {
                return Ok(_contatoAppService.RemoverContato(IdUsuario, IdContato));
            }
            
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
            
        }

        [HttpGet, Route("visualizar/{IdUsuario}")]
        public IActionResult VisualizarContato(Guid IdUsuario, [FromBody]Guid IdContato)
        {
            try
            {
                return Ok(_contatoAppService.VisualizarContato(IdUsuario, IdContato));
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new InternalServerError());
            }
            
        }

    }
}

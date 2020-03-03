using ContatosAPI.Shared.Util.Constantes;
using ContatosAPI.ApiError;
using System.Net;

namespace ContatoAPI.ApiErros
{
    public class InternalServerError : ApiError
    {
        public InternalServerError(string mensagem = MensagensDeErro.INTERNAL_SERVER_ERROR)
            : base((int)HttpStatusCode.InternalServerError, mensagem)
        {
        }
    }
}
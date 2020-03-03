
namespace ContatosAPI.ApiError
{
    public class ApiError
    {
        public int Status { get; set; }

        public string Mensagem { get; set; }

        public ApiError(int status, string mensagem)
        {
            Status = status;
            Mensagem = mensagem;
        }
    }
}
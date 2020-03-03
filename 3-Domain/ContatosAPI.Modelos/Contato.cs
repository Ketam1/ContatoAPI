using System;

namespace ContatosAPI.Domain.Modelos
{
    public class Contato
    {

        public Guid IdContato { get; set; }
        public string NomeContato { get; set; }
        public string NumeroTelefone { get; set; }
        public string IdSecundario { get; set; }
        public string Email { get; set; }

        public Contato() { }

        // Construtor para um contato com o ID
        public Contato(Guid IdContato, string NomeContato, string NumeroTelefone, string IdSecundario, string Email)
        {
            this.IdContato = IdContato;
            this.NomeContato = NomeContato;
            this.NumeroTelefone = NumeroTelefone;
            this.IdSecundario = IdSecundario;
            this.Email = Email;
        }

        // Construtor para um contato sem o ID
        public Contato(string NomeContato, string NumeroTelefone, string IdSecundario, string Email)
        {
            this.IdContato = Guid.NewGuid();
            this.NomeContato = NomeContato;
            this.NumeroTelefone = NumeroTelefone;
            this.IdSecundario = IdSecundario;
            this.Email = Email;
        }

        public Contato(Guid IdContato)
        {
            this.IdContato = IdContato;
        }


    }
}

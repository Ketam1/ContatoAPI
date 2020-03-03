using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.Domain.Modelos
{
    public class Usuario
    {
        public String NomeUsuario { get; set; }
        public Guid IdUsuario { get; set; }
        public List<Contato> ListaDeContatos { get; set; } 


        // Construtor vazio
        public Usuario() {
            List<Contato> NovaLista = new List<Contato>();
            this.ListaDeContatos = NovaLista; 
        }

        // Construtor para um novo usuário sem contatos
        public Usuario(String NomeUsuario)
        {
            List<Contato> NovaLista = new List<Contato>();

            IdUsuario = Guid.NewGuid();
            this.NomeUsuario = NomeUsuario;
            this.ListaDeContatos = NovaLista;
        }

        public Usuario(Guid IdUsuario, String NomeUsuario)
        {
            List<Contato> NovaLista = new List<Contato>();

            this.IdUsuario = IdUsuario;
            this.NomeUsuario = NomeUsuario;
            this.ListaDeContatos = NovaLista;
        }

        // Construtor para um novo usuário com ao menos 1 contato
        public Usuario(String NomeUsuario, List<Contato> ListaDeContatos)
        {
            IdUsuario = Guid.NewGuid();
            this.NomeUsuario = NomeUsuario;
            this.ListaDeContatos = ListaDeContatos;
        }

        public Usuario(Guid IdUsuario, String NomeUsuario, List<Contato> ListaDeContatos)
        {
            this.IdUsuario = IdUsuario;
            this.NomeUsuario = NomeUsuario;
            this.ListaDeContatos = ListaDeContatos;
        }

    }
}

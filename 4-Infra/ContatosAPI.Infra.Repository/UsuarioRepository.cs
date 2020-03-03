using System;
using System.Collections.Generic;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository.Interface;


namespace ContatosAPI.Infra.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public List<Usuario> ListaDeUsuarios = new List<Usuario>()
        {
            new Usuario(new Guid("55851c35-72b5-4c70-b7b4-d637c056b525"), "Usuário Teste")
        };


        public Contato AdicionarContato(Guid IdUsuario, Contato ContatoA)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);
            ListaDeUsuarios[IndexUsuario].ListaDeContatos.Add(ContatoA);

            return ContatoA;
        }
        public Guid RemoverContato(Guid IdUsuario, Guid IdContato)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);
            int IndexContato = AcharIndexContato(IndexUsuario, IdContato);
            ListaDeUsuarios[IndexUsuario].ListaDeContatos.RemoveAt(IndexContato);

            return IdUsuario;
        }
        public Contato EditarContato(Guid IdUsuario, Contato ContatoA)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);
            int IndexContato = AcharIndexContato(IndexUsuario, ContatoA.IdContato);
            ListaDeUsuarios[IndexUsuario].ListaDeContatos[IndexContato] = ContatoA;

            return ContatoA;
        }
        public Contato VisualizarContato(Guid IdUsuario, Guid IdContato)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);
            int IndexContato = AcharIndexContato(IndexUsuario, IdContato);
            Contato ContatoDesejado = ListaDeUsuarios[IndexUsuario].ListaDeContatos[IndexContato];

            return ContatoDesejado;
        }
        public Usuario AdicionarUsuario(Usuario UsuarioA)
        {
            ListaDeUsuarios.Add(UsuarioA);

            return UsuarioA;
        }
        public Guid RemoverUsuario(Guid IdUsuario)
        {
                int IndexUsuario = AcharIndexUsuario(IdUsuario);
                ListaDeUsuarios.RemoveAt(IndexUsuario);

                return IdUsuario;
        }
        public List<Contato> VisualizarContatos(Guid IdUsuario)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);

            return ListaDeUsuarios[IndexUsuario].ListaDeContatos;
        }

        public Usuario VisualizarUsuario(Guid IdUsuario)
        {
            int IndexUsuario = AcharIndexUsuario(IdUsuario);

            return ListaDeUsuarios[IndexUsuario];
        }

        #region Metódos Privados

        // Achar o index do usuário na ListaDeUsuários
        private int AcharIndexUsuario(Guid IdUsuario)
        {
            return ListaDeUsuarios.FindIndex(Usuario => Usuario.IdUsuario == IdUsuario);
        }

        // Achar o index de um contato numa ListaDeContatos numa ListaDeUsuários
        private int AcharIndexContato(int IndexUsuario, Guid IdContato)
        {
            return ListaDeUsuarios[IndexUsuario].ListaDeContatos.FindIndex(Contato => Contato.IdContato == IdContato);
        }

        #endregion

    }
}


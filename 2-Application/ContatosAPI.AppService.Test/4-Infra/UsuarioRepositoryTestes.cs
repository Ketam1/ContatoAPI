using AutoFixture;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService.Test._4_Infra
{
    class UsuarioRepositoryTestes
    {
        private Fixture _fixture;
        private Contato _contato;
        private Usuario _usuario;


        [OneTimeSetUp]
        public void InicializarFixture()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void Setup()
        {
            _usuario = _fixture.Create<Usuario>();
            _contato = _fixture.Create<Contato>();
        }

        public void DeveAdicionarUmUsuarioNoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();

            //When
            var VisualizacaoUsuario = Repository.AdicionarUsuario(_usuario);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            Assert.AreEqual(Repository.ListaDeUsuarios[IndexUsuario], VisualizacaoUsuario);
            
        }

        public void DeveRemoverUmUsuarioNoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);

            //When
            Repository.RemoverUsuario(_usuario.IdUsuario);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            Assert.AreEqual(IndexUsuario, -1);
        }

        public void DeveVisualizarUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);

            //When
            var ContatoVisualizacao = Repository.VisualizarUsuario(_usuario.IdUsuario);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            Assert.AreEqual(Repository.ListaDeUsuarios[IndexUsuario], ContatoVisualizacao);
        }

        public void DeveVisualizarTodosOsContatosDeUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);
            Repository.AdicionarContato(_usuario.IdUsuario, _contato);

            //When
            var ContatosVisualizacao = Repository.VisualizarContatos(_usuario.IdUsuario);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            Assert.AreEqual(Repository.ListaDeUsuarios[IndexUsuario].ListaDeContatos, ContatosVisualizacao);
        }

        public void DeveAdicionarUmContatoEmUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);        

            //When
            var ContatoVisualizacao = Repository.AdicionarContato(_usuario.IdUsuario, _contato);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            int IndexContato = AcharIndexContato(IndexUsuario, _contato.IdContato, Repository);
            Assert.AreEqual(_contato, ContatoVisualizacao);
        }

        public void DeveRemoverUmContatoDeUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);
            Repository.AdicionarContato(_usuario.IdUsuario, _contato);

            //When
            var ContatoGuidVisualizacao = Repository.RemoverContato(_usuario.IdUsuario, _contato.IdContato);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            int IndexContato = AcharIndexContato(IndexUsuario, ContatoGuidVisualizacao, Repository);
            Assert.AreEqual(IndexContato, -1);
        }
        public void DeveEditarUmContatoDeUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);
            Repository.AdicionarContato(_usuario.IdUsuario, _contato);

            var ContatoEditado = _fixture.Create<Contato>();
            ContatoEditado.IdContato = _contato.IdContato;

            //When
            var ContatoVisualizacao = Repository.EditarContato(_usuario.IdUsuario, ContatoEditado);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            int IndexContato = AcharIndexContato(IndexUsuario, ContatoVisualizacao.IdContato, Repository);
            Assert.AreEqual(ContatoVisualizacao, Repository.ListaDeUsuarios[IndexUsuario].ListaDeContatos[IndexContato]);
        }

        public void DeveVisualizarUmContatoDeUmUsuarioDoListaUsuarios()
        {
            //Given
            var Repository = InstanciarRepository();
            Repository.AdicionarUsuario(_usuario);
            Repository.AdicionarContato(_usuario.IdUsuario, _contato);

            //When
            var ContatoVisualizacao = Repository.VisualizarContato(_usuario.IdUsuario, _contato.IdContato);

            //Then
            int IndexUsuario = AcharIndexUsuario(_usuario.IdUsuario, Repository);
            int IndexContato = AcharIndexContato(IndexUsuario, ContatoVisualizacao.IdContato, Repository);
            Assert.AreEqual(ContatoVisualizacao, Repository.ListaDeUsuarios[IndexUsuario].ListaDeContatos[IndexContato]);
        }

        #region Métodos Privados

        private UsuarioRepository InstanciarRepository()
        {
            return new UsuarioRepository();
        }

        private int AcharIndexUsuario(Guid IdUsuario, UsuarioRepository Repository)
        {
            return Repository.ListaDeUsuarios.FindIndex(Usuario => Usuario.IdUsuario == IdUsuario);
        }

        private int AcharIndexContato(int IndexUsuario, Guid IdContato, UsuarioRepository Repository)
        {
            return Repository.ListaDeUsuarios[IndexUsuario].ListaDeContatos.FindIndex(Contato => Contato.IdContato == IdContato);
        }

        #endregion
    }
}

using AutoFixture;
using ContatoAPI.Domain.Interface;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain.Modelos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;

namespace ContatosAPI.AppService.Test
{
    [TestFixture]
    public class UsuarioAppServiceTestes
    {

        private Fixture _fixture;
        private Mock<IUsuarioService> _usuarioService;
        private string _nomeUsuario;
        private Guid _idUsuario;


        [OneTimeSetUp]
        public void InicializarFixture()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void InicializarServicos()
        {
            _usuarioService = new Mock<IUsuarioService>();
            _nomeUsuario = _fixture.Create<string>();
            _idUsuario = _fixture.Create<Guid>();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOAdicionarUsuarioAppService()
        {
            var appService = InstanciarAppService();

            appService.AdicionarUsuario(_nomeUsuario);

            _usuarioService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarORemoverUsuarioAppService()
        {
            var appService = InstanciarAppService();

            appService.RemoverUsuario(_idUsuario);

            _usuarioService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOVisualizarUsuarioAppService()
        {
            var appService = InstanciarAppService();

            appService.VisualizarUsuario(_idUsuario);

            _usuarioService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOVisualizarContatosAppService()
        {
            var appService = InstanciarAppService();

            appService.VisualizarUsuario(_idUsuario);

            _usuarioService.VerifyAll();
        }

        private UsuarioAppService InstanciarAppService()
        {
            return new UsuarioAppService(
                _usuarioService.Object
            );
        }

    }
}
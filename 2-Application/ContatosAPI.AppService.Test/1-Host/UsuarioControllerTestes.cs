using AutoFixture;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService.Test._1_Host
{
    class UsuarioControllerTestes
    {
        private Fixture _fixture;
        private Mock<IUsuarioAppService> _usuarioAppService;
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
            _usuarioAppService = new Mock<IUsuarioAppService>();
            _nomeUsuario = _fixture.Create<string>();
            _idUsuario = _fixture.Create<Guid>();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeAdicionarUsuario()
        {
            _usuarioAppService.Setup(
                mock => mock.AdicionarUsuario(_nomeUsuario)
            );
            var controller = InstanciarController();

            controller.AdicionarUsuario(_nomeUsuario);

            _usuarioAppService.Verify(
                mock => mock.AdicionarUsuario(It.IsAny<string>()),
                Times.Once());
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeRemoverUsuario()
        {
            _usuarioAppService.Setup(
                mock => mock.RemoverUsuario(_idUsuario)
            );
            var controller = InstanciarController();

            controller.RemoverUsuario(_idUsuario);

            _usuarioAppService.Verify(
                mock => mock.RemoverUsuario(It.IsAny<Guid>()),
                Times.Once()
            );
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeVisualizarUsuario()
        {
            _usuarioAppService.Setup(
                mock => mock.VisualizarUsuario(_idUsuario)
            );
            var controller = InstanciarController();

            controller.VisualizarUsuario(_idUsuario);

            _usuarioAppService.Verify(
                mock => mock.VisualizarUsuario(It.IsAny<Guid>()),
                Times.Once()
            );
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeVisualizarContatos()
        {
            _usuarioAppService.Setup(
                mock => mock.VisualizarContatos(_idUsuario)
            );
            var controller = InstanciarController();

            controller.VisualizarContatos(_idUsuario);

            _usuarioAppService.Verify(
                mock => mock.VisualizarContatos(It.IsAny<Guid>()),
                Times.Once()
            );
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveRetornarErro500CasoOcorraUmErroInternoDeProcessamento()
        {

        }

        #region Métodos Privados

        private UsuarioController InstanciarController()
        {
            return new UsuarioController(_usuarioAppService.Object);
        }

        #endregion
    }
}

using AutoFixture;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Controllers;
using ContatosAPI.Domain.Modelos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService.Test._1_Host
{
    class ContatoControllerTestes
    {
        private Fixture _fixture;
        private Mock<IContatoAppService> _contatoAppService;
        private Contato _contatoBase;
        private Usuario _usuario;

        [OneTimeSetUp]
        public void InicializarFixture()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void InicializarServicos()
        {
            _contatoAppService = new Mock<IContatoAppService>();
            _contatoBase = _fixture.Create<Contato>();
            _usuario = _fixture.Create<Usuario>();

        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeAdicionarContato()
        {
            _contatoAppService.Setup(
                mock => mock.AdicionarContato(_usuario.IdUsuario, _contatoBase)
            );           
            var controller = InstanciarController();

            controller.AdicionarContato(_usuario.IdUsuario, _contatoBase);

            _contatoAppService.Verify(
                mock => mock.AdicionarContato(It.IsAny<Guid>(), It.IsAny<Contato>()),
                Times.Once());

        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeRemoverContato()
        {
            _contatoAppService.Setup(
                mock => mock.RemoverContato(_usuario.IdUsuario, _contatoBase.IdContato)
            );
            var controller = InstanciarController();

            controller.RemoverContato(_usuario.IdUsuario, _contatoBase.IdContato);

            _contatoAppService.Verify(
                mock => mock.RemoverContato(It.IsAny<Guid>(), It.IsAny<Guid>()),
                Times.Once()
           );

        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeEditarContato()
        {
            _contatoAppService.Setup(
                mock => mock.EditarContato(_usuario.IdUsuario, _contatoBase)
            );
            var controller = InstanciarController();

            controller.EditarContato(_usuario.IdUsuario, _contatoBase);

            _contatoAppService.Verify(
                mock => mock.EditarContato(It.IsAny<Guid>(), It.IsAny<Contato>()),
                Times.Once()
           );
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveChamarUmaVezARotaDeVisualizarContato()
        {
            _contatoAppService.Setup(
                mock => mock.VisualizarContato(_usuario.IdUsuario, _contatoBase.IdContato)
            );
            var controller = InstanciarController();

            controller.VisualizarContato(_usuario.IdUsuario, _contatoBase.IdContato);

            _contatoAppService.Verify(
                mock => mock.VisualizarContato(It.IsAny<Guid>(), It.IsAny<Guid>()),
                Times.Once()
           );
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveRetornarErro500CasoOcorraUmErroInternoDeProcessamentoEmAdicionarContato()
        {

        }

        #region Métodos Privados

        private ContatoController InstanciarController()
        {
            return new ContatoController(_contatoAppService.Object);
        }

        #endregion
    }
}

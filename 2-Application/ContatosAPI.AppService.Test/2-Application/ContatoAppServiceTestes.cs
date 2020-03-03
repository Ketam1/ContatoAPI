using AutoFixture;
using ContatoAPI.Domain.Interface;
using ContatosAPI.Domain.Modelos;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService.Test._2_Application
{
    class ContatoAppServiceTestes
    {

        private Fixture _fixture;
        private Mock<IContatoService> _contatoService;
        private Guid _idContato;
        private Guid _idUsuario;

        [OneTimeSetUp]
        public void InicializarFixture()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void InicializarServicos()
        {
            _contatoService = new Mock<IContatoService>();
            _idContato = _fixture.Create<Guid>();
            _idUsuario = _fixture.Create<Guid>();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOAdicionarContatoAppService()
        {
            var appService = InstanciarAppService();

            appService.AdicionarContato(_idUsuario, It.IsAny<Contato>());

            _contatoService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarORemoverContatoAppService()
        {
            var appService = InstanciarAppService();

            appService.RemoverContato(_idUsuario, _idContato);

            _contatoService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOVisualizarContatoAppService()
        {
            var appService = InstanciarAppService();

            appService.VisualizarContato(_idUsuario, _idContato);

            _contatoService.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOEditarContatoAppService()
        {
            var appService = InstanciarAppService();

            appService.EditarContato(_idUsuario, It.IsAny<Contato>());

            _contatoService.VerifyAll();
        }

        private ContatoAppService InstanciarAppService()
        {
            return new ContatoAppService(
                _contatoService.Object
                );
        }
    }
}

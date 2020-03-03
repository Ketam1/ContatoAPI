using AutoFixture;
using ContatosAPI.Domain;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository.Interface;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.AppService.Test._3_Domain
{
    class ContatoServiceTestes
    {
        private Fixture _fixture;
        private Mock<IUsuarioRepository> _usuarioRepository;
        private Guid _idUsuario;
        private Guid _idContato;
        private Contato _contato;

        [OneTimeSetUp]
        public void InicializarFixture()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void InicializarServicos()
        {
            _usuarioRepository = new Mock<IUsuarioRepository>();

            _contato = _fixture.Create<Contato>();
            _idUsuario = _fixture.Create<Guid>();
            _idContato = _fixture.Create<Guid>();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOAdicionarContatoDomain()
        {
            var Service = InstanciarService();

            Service.AdicionarContato(_idUsuario, _contato);

            _usuarioRepository.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarORemoverContatoDomain()
        {
            var Service = InstanciarService();

            Service.RemoverContato(_idUsuario, _idContato);

            _usuarioRepository.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOVisualizarContatoDomain()
        {
            var Service = InstanciarService();

            Service.VisualizarContato(_idUsuario, _idContato);

            _usuarioRepository.VerifyAll();
        }

        [Test]
        [Category("TestesUnitarios")]
        public void DeveVerificarOEditarContatoDomain()
        {
            var Service = InstanciarService();

            Service.EditarContato(_idUsuario, It.IsAny<Contato>());

            _usuarioRepository.VerifyAll();
        }

        private ContatoService InstanciarService()
        {
            return new ContatoService(
                _usuarioRepository.Object
            );
        }
    }
}

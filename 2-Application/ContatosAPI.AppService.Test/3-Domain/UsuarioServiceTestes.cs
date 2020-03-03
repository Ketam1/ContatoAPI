using AutoFixture;
using ContatosAPI.Domain;
using ContatosAPI.Domain.Modelos;
using ContatosAPI.Infra.Repository;
using ContatosAPI.Infra.Repository.Interface;
using Moq;
using NUnit.Framework;
using System;

namespace ContatosAPI.AppService.Test._3_Domain
{
    class UsuarioServiceTestes
    {
        class ContatoServiceTestes
        {
            private Fixture _fixture;
            private Mock<IUsuarioRepository> _usuarioRepository;
            private Guid _idUsuario;

            [OneTimeSetUp]
            public void InicializarFixture()
            {
                _fixture = new Fixture();
            }

            [SetUp]
            public void InicializarServicos()
            {
                _usuarioRepository = new Mock<IUsuarioRepository>();
                _idUsuario = _fixture.Create<Guid>();
            }

            [Test]
            [Category("TestesUnitarios")]
            public void DeveVerificarOAdicionarUsuarioDomain()
            {
                var Service = InstanciarService();

                Service.AdicionarUsuario(It.IsAny<Usuario>());

                _usuarioRepository.VerifyAll();
            }

            [Test]
            [Category("TestesUnitarios")]
            public void DeveVerificarORemoverUsuarioDomain()
            {
                var Service = InstanciarService();

                Service.RemoverUsuario(_idUsuario);

                _usuarioRepository.VerifyAll();
            }

            [Test]
            [Category("TestesUnitarios")]
            public void DeveVerificarOVisualizarContatosDomain()
            {
                var Service = InstanciarService();

                Service.VisualizarContatos(_idUsuario);

                _usuarioRepository.VerifyAll();
            }

            [Test]
            [Category("TestesUnitarios")]
            public void DeveVerificarOVisualizarUsuarioDomain()
            {
                var Service = InstanciarService();

                Service.VisualizarUsuario(_idUsuario);

                _usuarioRepository.VerifyAll();
            }

            private UsuarioService InstanciarService()
            {
                return new UsuarioService(
                    _usuarioRepository.Object
                );
            }
        }
    }
}

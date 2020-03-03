using System;
using ContatosAPI.AppService;
using ContatosAPI.AppService.Interface;
using ContatosAPI.Domain;
using ContatoAPI.Domain.Interface;
using ContatosAPI.Infra.Repository.Interface;
using ContatosAPI.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ContatosAPI.Infra.IoC
{
    public static class IoCConfig
    {
        public static IServiceProvider ConfigureServices(IServiceCollection services)
        {
            ConfigurarAppServices(services);
            ConfigurarServices(services);
            ConfigurarRepositories(services);

            return services.BuildServiceProvider();
        }

        #region Métodos Privados

        private static void ConfigurarAppServices(IServiceCollection services)
        {
            services.AddSingleton<IContatoAppService, ContatoAppService>();
            services.AddSingleton<IUsuarioAppService, UsuarioAppService>();
        }

        private static void ConfigurarServices(IServiceCollection services)
        {
            services.AddSingleton<IContatoService, ContatoService>();
            services.AddSingleton<IUsuarioService, UsuarioService>();
        }

        private static void ConfigurarRepositories(IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
        }

        #endregion

    }
}

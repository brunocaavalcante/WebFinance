using Business.Core.Notificacoes;
using Business.Financas.Interfaces;
using Business.Financas.Services;
using Data.Context;
using Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IOperacaoRepository, OperacaoRepository>();
            services.AddScoped<INaturezaOperacaoRepository, NaturezaOperacaoRepository>();
            services.AddScoped<INaturezaOperacaoService, NaturezaOperacaoService>();
            services.AddScoped<INotificador, Notificador>();
            return services;
        }
    }
}

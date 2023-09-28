using Fiap.Application.Interfaces;
using Fiap.Application.Services;
using Fiap.Data.Context;
using Fiap.Data.Repositories;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Application.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void AddResolveDependecies(this IServiceCollection services)
        {
            //Application
            services.AddScoped<IPessoaApplicationService, PessoaApplicationService>();

            //Domain
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();

            //Data
            services.AddScoped<FiapContext>();
        }
    }
}

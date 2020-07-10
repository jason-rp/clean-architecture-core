using Infra.Data.Repositories;
using JLRP.Application.Interfaces;
using JLRP.Application.Services;
using JLRP.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}

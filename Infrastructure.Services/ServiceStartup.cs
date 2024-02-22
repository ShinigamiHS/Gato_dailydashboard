using Microsoft.Extensions.DependencyInjection;
using Repository.CommandQueries;
using Repository.Dapper;
using Repository.Interfaces;
using System.Net.NetworkInformation;

namespace Infrastructure.Services
{
    public static class ServiceStartup
    {
        public static void SetServices(IServiceCollection serviceCollection)
        {
            //Data.Repository Services
            serviceCollection.AddSingleton<ICommandQuery, CommandQuery>();
            serviceCollection.AddScoped<IRepositoryContext, DapperContext>();

            //Application.Core Services

            //Domain.Core Services

            //Mediator
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Ping).Assembly));
        }
    }
}

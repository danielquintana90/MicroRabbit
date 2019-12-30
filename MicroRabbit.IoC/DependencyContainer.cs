using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<BankingDbContext>();

            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Banking Microservice - Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Banking Microservice - Data
            services.AddTransient<IAccountRepository, AccountRepository>();            
        }
    }
}

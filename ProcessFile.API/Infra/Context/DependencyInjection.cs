using Microsoft.Extensions.DependencyInjection;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Infra.Repositories;
using ProcessFile.API.Providers.implementations;
using ProcessFile.API.Providers.Interface;
using ProcessFile.API.Services.Interfaces;
using ProcessFile.API.Services.Services;
using ProcessFile.API.Token;

namespace ProcessFile.API.Infra.Context
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection services)
        {
            services.AddScoped<IColumnControlService, ColumnControlService>();
            services.AddScoped<IColumnControlRepository, ColumnControlRepository>();
            services.AddScoped<IProcessService, ProcessService>();
            services.AddScoped<IProcessRepository, ProcessRepository>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ISulamericaService, SulamericaService>();
            services.AddScoped<ISulamericaRepository, SulamericaRepository>();
            services.AddScoped<IUnimedService, UnimedService>();
            services.AddScoped<IUnimedRepository, UnimedRepository>();
            services.AddScoped<IJobEventService, JobEventService>();
            services.AddScoped<IJobEventRepository, JobEventRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IHash, Hash>();
            services.AddScoped<ITokenGenerator, TokenGenerator>();
        }
    }
}

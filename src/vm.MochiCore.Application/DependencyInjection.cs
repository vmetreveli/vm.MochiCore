using Framework.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vm.MochiCore.Application.Services;

namespace vm.MochiCore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(DependencyInjection).Assembly);
        services.AddScoped<IMochiService, MochiService>();
        services.AddFramework(configuration, typeof(DependencyInjection).Assembly);

        return services;
    }
}
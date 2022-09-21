using ApiCorrelation.Configurations.Interfaces;
namespace ApiCorrelation.Services;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCorrelationIdGenerator(this IServiceCollection services)
    {
        services.AddScoped<ICorrelationIdGenerator, CorrelationIdGenerator>();

        return services;
    }
}
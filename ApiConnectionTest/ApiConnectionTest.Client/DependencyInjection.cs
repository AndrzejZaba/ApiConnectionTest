using ApiConnectionTest.Client.Services;

namespace ApiConnectionTest.Client;

public static class DependencyInjection
{
    public static IServiceCollection AddClient(this IServiceCollection services, Uri uri)
    {
        services.AddScoped(sp => new HttpClient { BaseAddress = uri });

        services.AddScoped<PolygonService>();

        return services;
    }
}

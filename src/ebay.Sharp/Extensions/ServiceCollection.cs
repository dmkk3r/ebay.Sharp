using ebay.Sharp.Features;
using ebay.Sharp.Features.Finding;
using Microsoft.Extensions.DependencyInjection;

namespace ebay.Sharp.Extensions;

public static class ServiceCollection {
    public static IServiceCollection AddEbaySharp(this IServiceCollection services, EbayConfiguration ebayConfiguration) {
        services.AddHttpClient("ebay-client", client => {
            client.DefaultRequestHeaders.Add("X-EBAY-SOA-GLOBAL-ID", ebayConfiguration.GlobalId);
            client.DefaultRequestHeaders.Add("X-EBAY-SOA-SECURITY-APPNAME", ebayConfiguration.AppId);
        });

        services.AddSingleton(ebayConfiguration);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(EbayHttpClient).Assembly));

        services.AddTransient<EbayHttpClient>();
        services.AddScoped<FindingService>();

        return services;
    }
}
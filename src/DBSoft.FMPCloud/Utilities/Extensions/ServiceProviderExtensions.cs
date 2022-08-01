using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.Utilities.Submitters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DBSoft.FMPCloud.Utilities
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection AddFMPCloud(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<ISubmitter, WebSubmitter>();
            services.AddSingleton<IFmpCloudClient>(x =>
            {
                return new FmpCloudClient(
                    x.GetService<IOptions<FMPCloudConfiguration>>().Value,
                    x.GetService<ISubmitter>(),
                    x.GetService<ILogger<FmpCloudClient>>()
                    );
            });
            return services;
        }
    }
}

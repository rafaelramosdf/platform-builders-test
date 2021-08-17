using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Infra;

namespace PlatformBuildersTest.Api
{
    public static class HostExtension
    {
        public static IHost SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var repository = services.GetService<IBinarySearchTreeNodeRepository>();
                new SeedData(repository).InitializeDb();
            }

            return host;
        }
    }
}

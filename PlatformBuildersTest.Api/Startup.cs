using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Objects;
using PlatformBuildersTest.Infra.Repositories;
using PlatformBuildersTest.Service.Services;

namespace PlatformBuildersTest.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MongoDbSettingsObject>(Configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<IMongoDbSettingsObject>(sp => sp.GetRequiredService<IOptions<MongoDbSettingsObject>>().Value);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlatformBuildersTest.Api", Version = "v1" });
            });

            services.AddTransient<IPalindromeService, PalindromeService>();
            services.AddTransient<IBinarySearchTreeService, BinarySearchTreeService>();
            services.AddTransient<IBinarySearchTreeNodeRepository, BinarySearchTreeNodeRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlatformBuildersTest.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

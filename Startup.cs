using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using f2e_GraphQL.models;
using f2e_GraphQL.services;
using Microsoft.Extensions.Options;

namespace f2e_GraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .AddQueryType<Query>();

            services.Configure<f2eDBSettings>(
                Configuration.GetSection(nameof(f2eDBSettings)));

            services.AddCors(options => 
                    options.AddDefaultPolicy(builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                ));

            services.AddSingleton<If2eDBSettings>(sp =>
                    sp.GetRequiredService<IOptions<f2eDBSettings>>().Value);

            services.AddSingleton<f2eService>();

            services.AddErrorFilter<CustomErrorFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors();
            app.UseRouting();            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}

using System;
using System.Reflection;
using System.IO;
using DWC.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DWC.API.Config;
using DWC.API.Models;
using Microsoft.EntityFrameworkCore;
using DWC.API.Repositories;

namespace DWC.API
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
            services.AddControllers();
            services.AddDbContext<DWCContext>(opt =>
                 opt.UseSqlServer("Server=tcp:watcheditmobileappsrv.database.windows.net,1433;Initial Catalog=WatchedItDb;Persist Security Info=False;User ID=watchedAdmin;Password=0123Adls;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

            services.AddSingleton<DataService>();
            //Repositories
            services.AddSingleton<IDeveloperRepository, DeveloperRepository>();

            //Services
            services.AddSingleton<IDeveloperService, DeveloperService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = SwaggerConfiguration.DocInfoVersion;
                    document.Info.Title = SwaggerConfiguration.DocInfoTitle;
                    document.Info.Description = SwaggerConfiguration.DocInfoDescription;
                    document.Info.TermsOfService = SwaggerConfiguration.TermsOfService;
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = SwaggerConfiguration.ContactName,
                        Email = string.Empty,
                        Url = SwaggerConfiguration.ContactUrl
                    };
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseOpenApi();
            app.UseSwaggerUi3();

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

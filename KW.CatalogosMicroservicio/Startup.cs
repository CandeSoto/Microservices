using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KW.CatalogosMicroservicio.Contexto;
using KW.CatalogosMicroservicio.Repositorios.Contratos;
using KW.CatalogosMicroservicio.Repositorios.Servicios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KW.CatalogosMicroservicio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy("allowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
            });

            services.AddControllers();
            services.AddDbContext<CatalogosDbContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("DevConnection")));

            //Scoped
            services.AddScoped<IPersonaRepository, PersonaRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseCors("allowAll");
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

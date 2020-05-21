using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using MS.HC.Domain.Commands;
using Template.AccessData.Commands;
using MSHCAccesData;
using System.Data;
using System.Data.SqlClient;

namespace MS.HC.Template.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.



        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContextPool<HCTemplateContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IGenericsRepository, GenericsRepository>();
            services.AddTransient<HistoriaClinicaService, HistoriaClinicaService>();
            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void ConfigureServices(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

    internal class HistoriaClinicaService
    {
    }
}

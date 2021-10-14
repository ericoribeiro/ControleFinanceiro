using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Contracts.Services;
using ControleFinanceiro.Domain.Service.Services;
using ControleFinanceiro.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ControleFinanceiro.UI
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
            services.AddTransient<IRepositorioDespesa, RepositorioDespesa>();
            services.AddTransient<IServicoDespesa, ServicoDespesa>();

            services.AddTransient<IRepositorioReceita, RepositorioReceita>();
            services.AddTransient<IServicoReceita, ServicoReceita>();

            //services.AddTransient<IRepositorioUsuario, RepositorioUsuario>();
            //services.AddTransient<IServicoUsuario, ServicoUsuario>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

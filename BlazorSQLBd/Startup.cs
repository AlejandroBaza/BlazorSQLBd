using BlazorSQLBd.Data.Services;
using BlazorSQLBd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorSQLBd
{
    public static class Startup
    {
        public static WebApplication InicializarApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }
        public static IConfiguration? Configuration { get; }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddControllers();

            //configurar cadena de conexion
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("mi_conexion")));

            //servicio de configuracion
            builder.Services.AddScoped<IEmpleadosService, EmpleadosService>();

        }
        public static void Configure(WebApplication app)
        {
            //
            app.UseCors();
            //Configure la canalización de solicitudes HTTP.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see <https://aka.ms/aspnetcore-hsts>.
                app.UseHsts();

            }
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");
        }

    }
}
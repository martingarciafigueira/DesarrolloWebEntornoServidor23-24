using Microsoft.EntityFrameworkCore;
using ProyectoPokemon.Models;
using System.Configuration;

namespace ProyectoPokemon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddDbContext<PokemonContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionMontecastelo")));

            builder.Services.AddDbContext<PokemonContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionMontecastelo"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                });
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
            name: "getPokemons",
            pattern: "Pokemon/GetPokemons/{atributos?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Pokemon}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
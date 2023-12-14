using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CentroPokemon.Models;
using CentroPokemon.Repository;
using System.Net;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CentroPokemonRepository>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("ConexionTarea4");
    return new CentroPokemonRepository(connectionString);
});

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationFormats.Add("/Views/GenerarEquipo/{0}.cshtml");
});


builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

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

app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "pokemon",
        pattern: "Pokemon/Lista",
        defaults: new { controller = "Pokemon", action = "Lista" });

    endpoints.MapControllerRoute(
        name: "pokemonDetails",
        pattern: "Pokemon/Detalles/{id}",
        defaults: new { controller = "Pokemon", action = "Detalles" });

    endpoints.MapControllerRoute(
        name: "miEquipo",
        pattern: "MiEquipo",
        defaults: new { controller = "MiEquipo", action = "Index" });

    endpoints.MapControllerRoute(
        name: "generarEquipo",
        pattern: "Pokemon/GenerarEquipo",
        defaults: new { controller = "Pokemon", action = "GenerarEquipo" });
    endpoints.MapControllerRoute(
        name: "combate",
        pattern: "Pokemon/Combate",
        defaults: new { controller = "Combate", action = "Combate" });


    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();

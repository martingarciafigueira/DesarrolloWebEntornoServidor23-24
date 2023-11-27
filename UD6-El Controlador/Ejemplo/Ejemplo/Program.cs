using Ejemplo.Controllers;
using System.Linq.Expressions;

var builder = WebApplication.CreateBuilder(args);

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
        name: "Product",
        pattern: "Products/{id}",
        defaults: new
        {
            controller = "Products",
            action = "Details"
        },
        constraints: new { id = @"\d{1,5}" }
        );

    app.MapControllerRoute(
        name: "Default",
        pattern: "admin/{controller}/{action}/{id?}",
        defaults: new
        {
            controller = "HomeAdmin",
            action = "Index"
        },
        new[] { "MyAplication.Controllers" }
        );

app.Run();

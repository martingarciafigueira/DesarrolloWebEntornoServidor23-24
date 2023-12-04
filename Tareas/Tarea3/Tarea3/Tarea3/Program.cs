using Microsoft.EntityFrameworkCore;
using Tarea3.Data;

var builder = WebApplication.CreateBuilder(args);

//Conexión Asignatura
builder.Services.AddDbContext<AsignaturaContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3") ,
  sqlServerOptionsAction: sqlOptions => {
    sqlOptions.EnableRetryOnFailure();
  });
});

//Conexión Estudiante
builder.Services.AddDbContext<EstudianteContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3") ,
  sqlServerOptionsAction: sqlOptions => {
    sqlOptions.EnableRetryOnFailure();
  });
});

//Conexión Profesor
builder.Services.AddDbContext<ProfesorContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3") ,
  sqlServerOptionsAction: sqlOptions => {
    sqlOptions.EnableRetryOnFailure();
  });
});

//Conexión Login
builder.Services.AddDbContext<LoginContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3") ,
  sqlServerOptionsAction: sqlOptions => {
    sqlOptions.EnableRetryOnFailure();
  });
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default" ,
    pattern: "{controller=Login}/{action=Logueate}/{id?}");

app.Run();

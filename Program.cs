using Microsoft.EntityFrameworkCore;
using PersonajesAPI.Data;


var builder = WebApplication.CreateBuilder(args);

// Agregar EF Core y la cadena de conexión
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews(); // o AddControllers() si es API

var app = builder.Build();

// Middleware usual
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapDefaultControllerRoute(); // MVC
// o app.MapControllers(); para Web API

app.Run();

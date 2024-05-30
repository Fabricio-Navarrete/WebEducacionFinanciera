using Microsoft.EntityFrameworkCore;
using ProyectoEducacionFinanciera.Data;

var builder = WebApplication.CreateBuilder(args);
var _config = builder.Configuration;
var _cnx = _config.GetConnectionString("DevConnection");
builder.Services.AddDbContext<DbProyectoContext>(options => options.UseSqlServer(_cnx));
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
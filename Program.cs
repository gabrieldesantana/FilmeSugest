using FilmeSugest.Data;
using FilmeSugest.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Add DataBase
builder.Services.AddDbContext<BancoContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));});
builder.Services.AddScoped<IFilmeRepositorio, FilmeRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

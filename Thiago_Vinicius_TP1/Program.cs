using Aniversariantes.Domain.Interfaces;
using Aniversariantes.Services;
using Aniversariantes.Services.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add service layer
builder.Services.AddScoped<IAniversariante, AniversarianteService>();

// DB Connection instance
builder.Services.AddDbContext<AniversariantesDbContext>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("AniversariantesDB"))
    );

//Session - definir cache
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

app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=aniversariante}/{action=listadeaniversariantes}");

app.Run();

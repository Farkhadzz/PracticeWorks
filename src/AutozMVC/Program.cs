using AutozMVC.Data.Database;
using AutozMVC.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string connectionStringName = "AutozDb";

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICarRepository, CarRepository>();
builder.Services.AddDbContext<AppDbContext>(options => {
    var connectionString = builder.Configuration.GetConnectionString(connectionStringName);
    options.UseSqlServer(connectionString);
});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

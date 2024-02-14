using Jale2.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();

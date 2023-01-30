using Authentication_And_Authorization_In_MVC;
using Authentication_And_Authorization_In_MVC.Models;
using Authentication_And_Authorization_In_MVC.Repositories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Authentication_And_Authorization_In_MVC.Data.ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));




builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepository<UserDetail,int>,RegisterRepository>(); //Adding dependency injection for the repository pattern 

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

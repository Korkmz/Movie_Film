using Microsoft.EntityFrameworkCore;
using Movie.Data.Access.Context;
using Movie.Service.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextFactory<MovieDbContext>(
    options =>
        options.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Test"));

ConfigureSetting.ServiceCollectionExtensions(builder.Services);

var app = builder.Build();
DataSeed.Seed(app);

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
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();
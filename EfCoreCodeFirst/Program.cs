using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
#region Builder

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<FavoriteRepository>();
builder.Services.AddScoped<OrderRepositories>();
builder.Services.AddScoped<CategoryRepository>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion

var app = builder.Build();

#region App

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/500");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");


#endregion

app.Run();

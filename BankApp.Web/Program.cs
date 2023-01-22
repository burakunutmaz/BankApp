using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using BankApp.Web.Data.Context;
using BankApp.Web.Data.Interfaces;
using BankApp.Web.Data.Repositories;
using BankApp.Web.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<BankContext>(opt =>
{
    opt.UseSqlServer("server=(localdb)\\mssqllocaldb; database=BankDb; integrated security=true;");
});
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IUserMapper, UserMapper>();
builder.Services.AddScoped<IAccountMapper, AccountMapper>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapRazorPages();

app.UseStaticFiles();

app.UseStaticFiles(
    new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),
            "node_modules")),
        RequestPath = "/node_modules"
    });

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.Run();




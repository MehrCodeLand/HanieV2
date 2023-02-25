using HanieV2.Core.Repositories.AdminRepo;
using HanieV2.Core.Services.AdminSer;
using HanieV2.Data.DbFile;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDb>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("MyConStr")
    ));
builder.Services.AddScoped<IAdminService, AdminRepository>();
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
    pattern: "{area=admin}/{controller=Home}/{action=Index}/{id?}");

app.Run(); 

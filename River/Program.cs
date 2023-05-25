using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using River.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");//RiverContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//#####################
builder.Services.AddDefaultIdentity<IdentityUser>
(options => options.SignIn.RequireConfirmedAccount = true)
.AddRoles<IdentityRole>() //Roles are added
.AddEntityFrameworkStores<ApplicationDbContext>();

//#####################
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//#####################
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//#####################

app.UseSession();
//#####################

//app.MapControllerRoute(
//    name: "admin",
//    pattern: "{controller=Admin}/{action=ManageUserRoles}/{id?}");

app.MapControllerRoute(
    name: "users",
    pattern: "{controller=User}/{action=GetUser}/{id?}");
app.MapControllerRoute(
    name: "admin",
    pattern: "{controller=Admin}/{action=AddRole}/{id?}");
app.MapControllerRoute(
    name: "admin",
    pattern: "{controller=Admin}/{action=GetUsers}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

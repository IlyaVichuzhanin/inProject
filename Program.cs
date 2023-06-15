using inProject.Data;
using inProject.Models.Domain;
using inProject.Utilites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//var connectionString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<AppDbContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IDbInitializer, DbInitializer>();

var app = builder.Build();
DataSeeding();

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

void DataSeeding()
{
    using (var scope = app.Services.CreateScope())
    {
        var DbInitialixer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        DbInitialixer.Initialize();
    }
}

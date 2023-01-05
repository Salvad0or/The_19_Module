using _The19Module.Services.Interfaces;
using _The19Module.Services.PerconServices;
using Microsoft.EntityFrameworkCore;
using The19Module.DAL;
using The19Module.DAL.Interfaces;
using The19Module.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Services


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<The19ModuleContext>(options =>
{
    options.UseSqlServer(connection);
});

#endregion

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

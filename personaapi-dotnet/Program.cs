using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TelefonoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TelefonoContext") ?? throw new InvalidOperationException("Connection string 'TelefonoContext' not found.")));
builder.Services.AddDbContext<ProfesionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProfesionContext") ?? throw new InvalidOperationException("Connection string 'ProfesionContext' not found.")));
builder.Services.AddDbContext<PersonaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PersonaContext") ?? throw new InvalidOperationException("Connection string 'PersonaContext' not found.")));
builder.Services.AddDbContext<EstudioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EstudioContext") ?? throw new InvalidOperationException("Connection string 'EstudioContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
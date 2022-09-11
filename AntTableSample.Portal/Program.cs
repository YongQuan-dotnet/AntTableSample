using AntTableSample.Portal.Data;
using AntTableSample.Portal.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAntDesign();
builder.Services.AddSingleton<WeatherForecastService>();

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
void BuildOptions(DbContextOptionsBuilder options) => options
    .UseSqlServer(config.GetConnectionString("DefaultConnection"));

builder.Services.AddDbContextFactory<PropertyDbContext>(BuildOptions);

MigrateDB();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


void MigrateDB()
{
    var context = builder.Services.BuildServiceProvider().GetRequiredService<PropertyDbContext>();
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }
}
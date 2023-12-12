using CoolKicks.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;

var builder = WebApplication.CreateBuilder(args);

//Repository implementations
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ISneakerRepository, SneakerRepository>();


//enablin MVC in Application
builder.Services.AddControllersWithViews();

//registering EF Core
builder.Services.AddDbContext<CoolKicksDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration["ConnectionStrings:CoolKicksDbContext"]);

    });

var app = builder.Build();

//middleware to make application use the wwwroot folder and see the files in there
app.UseStaticFiles();

//Diagnostic middleware component that will show the exception page only when application is in development enviroment
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//middleware that will let mvc handle the incoming requests on controllers
app.MapDefaultControllerRoute();

//Creating my seed data
DbInitializer.Seed(app);

//will start the application.
app.Run();

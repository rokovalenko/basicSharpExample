using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using TestApp.Data.Infra;
using TestApp.Data.Repositories;
using TestApp.Services;


var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints().SwaggerDocument();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("TestDb"));

builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddScoped<UserRepository>();

var app = builder.Build();

app.UseFastEndpoints().UseSwaggerGen();
app.Run();

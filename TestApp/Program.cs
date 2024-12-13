using FastEndpoints;
using FastEndpoints.Swagger;
using TestApp.User;


var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints().SwaggerDocument();
builder.Services.AddUserModuleDependencies();

var app = builder.Build();

app.UseFastEndpoints().UseSwaggerGen();
app.Run();

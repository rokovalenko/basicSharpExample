using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestApp.User.Data.Infra;
using TestApp.User.Data.Repositories;
using TestApp.User.Services;

namespace TestApp.User;

public static class DependencyInjection
{
    public static IServiceCollection AddUserModuleDependencies(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("TestDb"));
        services.AddSingleton<IUserService, UserService>();
        services.AddScoped<UserRepository>();

        return services;
    }
}
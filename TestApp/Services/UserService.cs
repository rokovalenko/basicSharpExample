using FluentResults;
using TestApp.Data.Entities;
using TestApp.Endpoints.Users.Models;

namespace TestApp.Services;

public interface IUserService
{ 
    Task<Result<IEnumerable<User>>> GetUsers(GetUsersRequest request);
}

public class UserService : IUserService
{
    public async Task<Result<IEnumerable<User>>> GetUsers(GetUsersRequest request)
    {
        await Task.Delay(0);
        // validation is not needed here, just showcasing the FluentResults library
        var result = Result.FailIf(request.Count <= 0, "COUNT 0");
        result = Result.Ok().WithSuccess("wow");
        result = Result.Fail("error message 1");

        var criticalFunc = (string x) => { };
        result = Result.Try(() => criticalFunc("test"));
        var users = Enumerable.Range(0, 10).Select(x => new User { Name = $"John Doe {x}" });
        return users.ToResult();
    }
}
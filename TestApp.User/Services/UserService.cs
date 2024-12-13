using FluentResults;
using TestApp.User.Data.Entities;
using TestApp.User.Endpoints.Users.Models;

namespace TestApp.User.Services;

public interface IUserService
{ 
    Task<Result<IEnumerable<UserEntity>>> GetUsers(GetUsersRequest request);
}

public class UserService : IUserService
{
    public async Task<Result<IEnumerable<UserEntity>>> GetUsers(GetUsersRequest request)
    {
        await Task.Delay(0);
        // validation is not needed here, just showcasing the FluentResults library
        var result = Result.FailIf(request.Count <= 0, "COUNT 0");
        result = Result.Ok().WithSuccess("wow");
        result = Result.Fail("error message 1");

        var criticalFunc = (string x) => { };
        result = Result.Try(() => criticalFunc("test"));
        var users = Enumerable.Range(0, 10).Select(x => new UserEntity { Name = $"John Doe {x}" });
        return users.ToResult();
    }
}
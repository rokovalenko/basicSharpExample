using System.Net;
using FastEndpoints;
using TestApp.User.Endpoints.Users.Models;
using TestApp.User.Services;

namespace TestApp.User.Endpoints.Users;

public class GetUsersEndpoint(IUserService userService) : Endpoint<GetUsersRequest, GetUsersResponse>
{
    public override void Configure()
    {
        Verbs(WebRequestMethods.Http.Get);
        Get("/users");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(GetUsersRequest req, CancellationToken ct)
    {
        Console.WriteLine(req.Count);
        var results = await userService.GetUsers(req);
        await SendAsync(new GetUsersResponse(results.Value), cancellation: ct);
    }
}
using FastEndpoints;
using FluentResults;
using TestApp.Endpoints.Users.Models;
using TestApp.Services;

namespace TestApp.Endpoints.Users;

public class GetUsersEndpoint(IUserService userService) : Endpoint<GetUsersRequest, GetUsersResponse>
{
    public override void Configure()
    {
        Verbs(Http.GET);
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
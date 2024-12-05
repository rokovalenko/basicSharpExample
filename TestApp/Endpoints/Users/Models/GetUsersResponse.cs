using TestApp.Data.Entities;

namespace TestApp.Endpoints.Users.Models;

public record GetUsersResponse(IEnumerable<User> Users);
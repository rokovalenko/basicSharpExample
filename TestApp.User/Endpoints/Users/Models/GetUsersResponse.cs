using TestApp.User.Data.Entities;

namespace TestApp.User.Endpoints.Users.Models;

public record GetUsersResponse(IEnumerable<UserEntity> Users);
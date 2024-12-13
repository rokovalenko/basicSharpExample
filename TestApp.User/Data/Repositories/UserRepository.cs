using TestApp.User.Data.Entities;
using TestApp.User.Data.Infra;

namespace TestApp.User.Data.Repositories;

public class UserRepository(ApplicationDbContext context)
{
    public async Task<IEnumerable<UserEntity>> GetUsers(int count)
    {
        await Task.Delay(1);
        return context.Users;
    }
}
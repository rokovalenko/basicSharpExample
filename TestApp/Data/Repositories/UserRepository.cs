using TestApp.Data.Entities;
using TestApp.Data.Infra;

namespace TestApp.Data.Repositories;

public class UserRepository(ApplicationDbContext context)
{
    public async Task<IEnumerable<User>> GetUsers(int count)
    {
        await Task.Delay(1);
        return context.Users;
    }
}
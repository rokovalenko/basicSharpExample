using Microsoft.EntityFrameworkCore;
using TestApp.User.Data.Entities;

namespace TestApp.User.Data.Infra;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
}

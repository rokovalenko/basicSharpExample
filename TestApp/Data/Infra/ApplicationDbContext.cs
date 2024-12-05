using Microsoft.EntityFrameworkCore;
using TestApp.Data.Entities;

namespace TestApp.Data.Infra;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}

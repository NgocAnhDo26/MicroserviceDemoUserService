using MicroserviceDemoUserService.Model;
using Microsoft.EntityFrameworkCore;

namespace UserService.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    // Optional: Seed initial data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Alice Smith", Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob Johnson", Email = "bob@example.com" }
        );
    }
}
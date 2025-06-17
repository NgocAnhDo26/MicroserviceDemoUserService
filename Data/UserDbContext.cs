using MicroserviceDemoUserService.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceDemoUserService.Data;

public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
{
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
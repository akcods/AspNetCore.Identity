using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Identity.Database;

public class AppDbContext: IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().Property(user => user.Initials).HasMaxLength(5);
        modelBuilder.HasDefaultSchema("Identity");
    }
}
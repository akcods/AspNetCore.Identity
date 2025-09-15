using AspNetCore.Identity.Database;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Identity.Extensions;

public static class MigrationExtension
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
        using AppDbContext context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
        context.Database.Migrate();
    }
}
using Microsoft.EntityFrameworkCore;

namespace MauiApp1;

internal sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }
}
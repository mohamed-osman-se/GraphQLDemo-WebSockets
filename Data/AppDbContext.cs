using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.LogTo(
    Console.WriteLine,
         new[] { DbLoggerCategory.Database.Command.Name },
         LogLevel.Information
        );
    }
}

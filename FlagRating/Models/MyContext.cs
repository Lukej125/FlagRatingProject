#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace FlagRating.Models;
public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Flag> Flags { get; set; }
    public DbSet<Rating> Ratings { get; set; }
}
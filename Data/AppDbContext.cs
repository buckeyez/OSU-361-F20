using Microsoft.EntityFrameworkCore;
using ExpertFinder.Models;

namespace ExpertFinder.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
    {
    }

    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Skills> Skills { get; set; }
    public DbSet<Titles> Titles { get; set; }
    public DbSet<Users> Users { get; set; }
  }
}

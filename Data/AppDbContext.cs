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
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}

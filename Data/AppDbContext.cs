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

    public DbSet<Course> Courses { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<ProfileCourses> ProfileCourses { get; set; }
    public DbSet<ProfileSkills> ProfileSkills { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<ProfileCourses>(entity =>
      {
        entity.HasKey(e => new { e.ProfileId, e.CourseId });

        entity.HasOne(e => e.Profile)
          .WithMany(p => p.ProfileCourses)
          .HasForeignKey(e => e.ProfileId);

        entity.HasOne(e => e.Course)
          .WithMany(c => c.ProfileCourses)
          .HasForeignKey(e => e.CourseId);
      });

      modelBuilder.Entity<ProfileSkills>(entity =>
      {
        entity.HasKey(e => new { e.ProfileId, e.SkillId });

        entity.HasOne(e => e.Profile)
          .WithMany(p => p.ProfileSkills)
          .HasForeignKey(e => e.ProfileId);

        entity.HasOne(e => e.Skill)
          .WithMany(s => s.ProfileSkills)
          .HasForeignKey(e => e.SkillId);
      });

      modelBuilder.Entity<User>(entity =>
      {
        entity.HasIndex(e => e.Name)
          .IsUnique();
      });
    }
  }
}

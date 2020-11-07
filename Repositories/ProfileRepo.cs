using Microsoft.EntityFrameworkCore;
using ExpertFinder.Data;
using ExpertFinder.Projections;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ExpertFinder.Repositories
{
  public class ProfileRepo : IProfileRepo
  {
    private AppDbContext _db;

    public ProfileRepo(AppDbContext db)
    {
      _db = db;
    }

    public Task<List<Profile>> GetAllProfilesAsync()
    {
      return _db.Profiles
        .AsQueryable()
        .Select(p => new Profile
        {
          Title = p.Title.Value,
          FirstName = p.FirstName,
          LastName = p.LastName,
          Email = p.Email,
          GitHub = p.GitHub,
          LinkedIn = p.LinkedIn,
          Organization = p.Organization,
          Picture = p.Picture,
          Courses = p.ProfileCourses
            .Select(pc => $"{pc.Course.NumberPrefix} {pc.Course.Number}")
            .ToList(),
          Skills = p.ProfileSkills
            .Select(ps => ps.Skill.Name)
            .ToList()
        })
        .ToListAsync();
    }

    public Task<Profile> GetProfileAsync(int id)
    {
      return _db.Profiles
        .AsQueryable()
        .Where(p => p.Id == id)
        .Select(p => new Profile
        {
          Title = p.Title.Value,
          FirstName = p.FirstName,
          LastName = p.LastName,
          Email = p.Email,
          GitHub = p.GitHub,
          LinkedIn = p.LinkedIn,
          Organization = p.Organization,
          Picture = p.Picture,
          Courses = p.ProfileCourses
            .Select(pc => $"{pc.Course.NumberPrefix} {pc.Course.Number}")
            .ToList(),
          Skills = p.ProfileSkills
            .Select(ps => ps.Skill.Name)
            .ToList()
        })
        .FirstOrDefaultAsync();
    }
  }
}

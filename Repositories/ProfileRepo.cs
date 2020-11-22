using Microsoft.EntityFrameworkCore;
using ExpertFinder.Data;
using ExpertFinder.Projections;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace ExpertFinder.Repositories
{
  public class ProfileRepo : IProfileRepo
  {
    private AppDbContext _db;

    public ProfileRepo(AppDbContext db)
    {
      _db = db;
    }

    public async Task<Models.Profile> AddProfileAsync(Profile profile)
    {
      var newProfile = new Models.Profile
      {
        FirstName = profile.FirstName,
        LastName = profile.LastName,
        Biography = profile.Biography,
        Email = profile.Email,
        GitHub = profile.GitHub,
        LinkedIn = profile.LinkedIn,
        Organization = profile.Organization,
        Picture = profile.Picture,
        Title = await _db.Titles.Where(t => t.Value == profile.Title).FirstAsync()
      };

      _db.Add<Models.Profile>(newProfile);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateException e)
      {
        Console.WriteLine(e.Message);
        return new Models.Profile();
      }

      return await _db.Profiles.Where(p => p == newProfile).FirstAsync();
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
          Biography = p.Biography,
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
          Biography = p.Biography,
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

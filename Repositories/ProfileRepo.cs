using Microsoft.EntityFrameworkCore;
using ExpertFinder.Data;
using ExpertFinder.Projections;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class ProfileRepo : IProfileRepo
  {
    private AppDbContext _db;

    public ProfileRepo(AppDbContext db)
    {
      _db = db;
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
          Skills = p.ProfileSkills
            .Select(ps => ps.Skill.Name)
            .ToList()
        })
        .FirstOrDefaultAsync();
    }
  }
}

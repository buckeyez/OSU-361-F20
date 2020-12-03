using ExpertFinder.Data;
using ExpertFinder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class ProfileSkillsRepo : IProfileSkillsRepo
  {
    private AppDbContext _db;

    public ProfileSkillsRepo(AppDbContext db)
    {
      _db = db;
    }

    public async Task<bool> AddRelations(Profile profile, ICollection<string> skills)
    {
      foreach (string skill in skills)
      {
        _db.Add<ProfileSkills>(new ProfileSkills
        {
          Profile = profile,
          Skill = await _db.Skills.Where(s => s.Name == skill).FirstAsync()
        });
      }

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateException e)
      {
        Console.WriteLine(e.Message);
        return false;
      }

      return true;
    }
  }
}

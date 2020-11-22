using ExpertFinder.Data;
using ExpertFinder.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class SkillRepo : ISkillRepo
  {
    private AppDbContext _db;

    public SkillRepo(AppDbContext db)
    {
      _db = db;
    }

    public Task<List<Skill>> GetSkillsAsync()
    {
      return _db.Skills
        .AsQueryable()
        .OrderBy(s => s.Name)
        .ToListAsync();
    }
  }
}

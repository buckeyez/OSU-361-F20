using ExpertFinder.Data;
using ExpertFinder.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class TitleRepo : ITitleRepo
  {
    private AppDbContext _db;

    public TitleRepo(AppDbContext db)
    {
      _db = db;
    }

    Task<List<Title>> ITitleRepo.GetTitlesAsync()
    {
      return _db.Titles
        .AsQueryable()
        .OrderBy(t => t.Value)
        .ToListAsync();
    }
  }
}

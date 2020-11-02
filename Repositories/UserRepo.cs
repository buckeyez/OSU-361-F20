using Microsoft.EntityFrameworkCore;
using ExpertFinder.Data;
using ExpertFinder.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class UserRepo : IUserRepo
  {
    private AppDbContext _db;

    public UserRepo(AppDbContext db)
    {
      _db = db;
    }

    public Task<User> GetUserAsync(string name)
    {
      return _db.Users
        .AsQueryable()
        .Where(u => u.Name == name)
        .FirstOrDefaultAsync();
    }
  }
}

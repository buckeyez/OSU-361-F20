using Microsoft.EntityFrameworkCore;
using ExpertFinder.Data;
using ExpertFinder.Models;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ExpertFinder.Repositories
{
  public class UserRepo : IUserRepo
  {
    private AppDbContext _db;

    public UserRepo(AppDbContext db)
    {
      _db = db;
    }

    public async Task<bool> AddUserAsync(User user)
    {
      _db.Add(user);
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateException e)
      {
        Console.WriteLine("User already exists!");
        return false;
      }

      return true;
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

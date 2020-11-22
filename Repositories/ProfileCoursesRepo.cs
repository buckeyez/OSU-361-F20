using ExpertFinder.Data;
using ExpertFinder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class ProfileCoursesRepo : IProfileCoursesRepo
  {
    private AppDbContext _db;

    public ProfileCoursesRepo(AppDbContext db)
    {
      _db = db;
    }

    public async Task<bool> AddRelations(Profile profile, ICollection<string> courses)
    {
      foreach (string course in courses)
      {
        var cn = course.Split(' ');

        _db.Add<ProfileCourses>(new ProfileCourses
        {
          Profile = profile,
          Course = await _db.Courses.Where(c => c.NumberPrefix == cn[0] && c.Number == Int32.Parse(cn[1])).FirstAsync()
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

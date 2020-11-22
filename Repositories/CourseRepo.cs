using ExpertFinder.Data;
using ExpertFinder.Projections;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public class CourseRepo : ICourseRepo
  {
    private AppDbContext _db;

    public CourseRepo(AppDbContext db)
    {
      _db = db;
    }
    Task<List<Course>> ICourseRepo.GetCoursesAsync()
    {
      return _db.Courses
        .AsQueryable()
        .OrderBy(c => c.Number)
        .Select(c => new Course
        {
          Id = c.Id,
          CourseName = c.Name,
          CourseNumber = $"{c.NumberPrefix} {c.Number}",
        })
        .ToListAsync();
    }
  }
}

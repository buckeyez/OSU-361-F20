using ExpertFinder.Projections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface ICourseRepo
  {
    Task<List<Course>> GetCoursesAsync();
  }
}

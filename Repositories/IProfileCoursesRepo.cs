using ExpertFinder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IProfileCoursesRepo
  {
    Task<bool> AddRelations(Profile profile, ICollection<string> courses);
  }
}

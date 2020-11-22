using ExpertFinder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IProfileSkillsRepo
  {
    Task<bool> AddRelations(Profile profile, ICollection<string> skills);
  }
}

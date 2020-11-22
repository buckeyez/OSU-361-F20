using ExpertFinder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface ISkillRepo
  {
    Task<List<Skill>> GetSkillsAsync();
  }
}

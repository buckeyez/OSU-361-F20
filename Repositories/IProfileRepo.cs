using ExpertFinder.Projections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IProfileRepo
  {
    Task<List<Profile>> GetAllProfilesAsync();
    Task<Profile> GetProfileAsync(int id);
  }
}

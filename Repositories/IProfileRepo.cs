using ExpertFinder.Projections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IProfileRepo
  {
    Task<Models.Profile> AddProfileAsync(Profile profile);
    Task<List<Profile>> GetAllProfilesAsync();
    Task<Profile> GetProfileAsync(int id);
  }
}

using ExpertFinder.Projections;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IProfileRepo
  {
    Task<Profile> GetProfileAsync(int id);
  }
}

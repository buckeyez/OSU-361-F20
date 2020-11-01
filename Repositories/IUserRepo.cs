using ExpertFinder.Models;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IUserRepo
  {
    Task<User> GetUserAsync(string name);
  }
}

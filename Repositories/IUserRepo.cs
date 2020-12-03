using ExpertFinder.Models;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IUserRepo
  {
    Task<bool> AddUserAsync(User user);
    Task<User> GetUserAsync(string name);
  }
}

using ExpertFinder.Models;
using System.Threading.Tasks;

namespace ExpertFinder.Repositories
{
  public interface IUserRepo
  {
    Task<Users> GetUserAsync(string name);
  }
}

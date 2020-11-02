using Microsoft.AspNetCore.Mvc;
using ExpertFinder.Models;
using ExpertFinder.Repositories;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UserController : Controller
  {
    private IUserRepo _userRepo;

    public UserController(IUserRepo userRepo)
    {
      _userRepo = userRepo;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<User>> GetUser(string name)
    {
      var result = await _userRepo.GetUserAsync(name);

      if (result == null)
      {
        return NotFound();
      }

      return result;
    }
  }
}

using Microsoft.AspNetCore.Mvc;
using ExpertFinder.Models;
using ExpertFinder.Repositories;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : Controller
  {
    private IUserRepo _userRepo;

    public UsersController(IUserRepo userRepo)
    {
      _userRepo = userRepo;
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddUser([FromForm] User user)
    {
      var result = await _userRepo.AddUserAsync(user);

      if (!result)
      {
        return Conflict();
      }

      return CreatedAtAction(nameof(GetUser), new { name = user.Name }, user);
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

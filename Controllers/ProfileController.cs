using Microsoft.AspNetCore.Mvc;
using ExpertFinder.Models;
using ExpertFinder.Repositories;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProfileController : Controller
  {
    private IProfileRepo _profileRepo;

    public ProfileController(IProfileRepo profileRepo)
    {
      _profileRepo = profileRepo;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Profile>> GetProfile(int id)
    {
      var result = await _profileRepo.GetProfileAsync(id);

      if (result == null)
      {
        return NotFound();
      }

      return result;
    }
  }
}

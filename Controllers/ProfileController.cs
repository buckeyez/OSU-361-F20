using Microsoft.AspNetCore.Mvc;
using ExpertFinder.Projections;
using ExpertFinder.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;

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

    [HttpGet("all")]
    public async Task<List<Profile>> GetAllProfiles() => await _profileRepo.GetAllProfilesAsync();

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

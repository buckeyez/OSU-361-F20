using Microsoft.AspNetCore.Mvc;
using ExpertFinder.Projections;
using ExpertFinder.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProfilesController : Controller
  {
    private IProfileRepo _profileRepo;
    private IProfileCoursesRepo _pcRepo;
    private IProfileSkillsRepo _psRepo;

    public ProfilesController(IProfileRepo profileRepo, IProfileSkillsRepo psRepo, IProfileCoursesRepo pcRepo)
    {
      _profileRepo = profileRepo;
      _pcRepo = pcRepo;
      _psRepo = psRepo;
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddProfile([FromBody] Profile profile)
    {
      var newProfile = await _profileRepo.AddProfileAsync(profile);

      var tasks = new List<Task>();
      tasks.Add(_psRepo.AddRelations(newProfile, profile.Skills));
      tasks.Add(_pcRepo.AddRelations(newProfile, profile.Courses));
      Task t = Task.WhenAll(tasks);

      try
      {
        t.Wait();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return Conflict();
      }

      return CreatedAtAction(nameof(GetProfile), new { id = newProfile.Id }, profile);
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

    [HttpGet]
    public async Task<List<Profile>> GetAllProfiles() => await _profileRepo.GetAllProfilesAsync();
  }
}

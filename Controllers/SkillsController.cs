using ExpertFinder.Models;
using ExpertFinder.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class SkillsController : Controller
  {
    private ISkillRepo _skillRepo;

    public SkillsController(ISkillRepo skillRepo)
    {
      _skillRepo = skillRepo;
    }

    [HttpGet]
    public async Task<List<Skill>> GetSkills()
    {
      return await _skillRepo.GetSkillsAsync();
    }
  }
}

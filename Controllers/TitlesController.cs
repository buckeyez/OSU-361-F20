using ExpertFinder.Models;
using ExpertFinder.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TitlesController : Controller
  {
    private ITitleRepo _repo;

    public TitlesController(ITitleRepo repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public async Task<List<Title>> GetTitles()
    {
      return await _repo.GetTitlesAsync();
    }
  }
}

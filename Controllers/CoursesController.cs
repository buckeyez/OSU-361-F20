using ExpertFinder.Projections;
using ExpertFinder.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpertFinder.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CoursesController : Controller
  {
    private ICourseRepo _repo;

    public CoursesController(ICourseRepo repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public async Task<List<Course>> GetCourses()
    {
      return await _repo.GetCoursesAsync();
    }
  }
}

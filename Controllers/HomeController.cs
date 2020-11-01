using Microsoft.AspNetCore.Mvc;

namespace ExpertFinder.Controllers
{
  [Route("/")]
  public class HomeController : Controller
  {
    public IActionResult Index() => View();
  }
}

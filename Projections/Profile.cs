using System.Collections.Generic;

namespace ExpertFinder.Projections
{
  public class Profile
  {
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string GitHub { get; set; }
    public string LinkedIn { get; set; }
    public string Organization { get; set; }
    public string Biography { get; set; }
    public string Picture { get; set; }
    public ICollection<string> Courses { get; set; }
    public ICollection<string> Skills { get; set; }
  }
}

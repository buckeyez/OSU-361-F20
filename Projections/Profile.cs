using System.Collections.Generic;

namespace ExpertFinder.Projections
{
  public class Profile
  {
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<string> Skills { get; set; }
  }
}

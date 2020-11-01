using System.Collections.Generic;

namespace ExpertFinder.Models
{
  public class Profile
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TitleId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Skills> Skills { get; } = new List<Skills>();

    public Titles Title { get; set; }
    public Users User { get; set; }
  }
}

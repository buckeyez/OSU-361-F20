using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Profile
  {
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    public Title Title { get; set; }
    public User User { get; set; }
  }
}

using System.Collections.Generic;
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

    public string Biography { get; set; }
    public string Email { get; set; }
    public string GitHub { get; set; }
    public string LinkedIn { get; set; }
    public string Organization { get; set; }
    public string Picture { get; set; }

    public Title Title { get; set; }
    public User User { get; set; }

    public ICollection<ProfileCourses> ProfileCourses { get; set; }
    public ICollection<ProfileSkills> ProfileSkills { get; set; }
  }
}

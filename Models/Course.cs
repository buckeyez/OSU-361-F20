using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Course
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string NumberPrefix { get; set; }
    [Required]
    public int Number { get; set; }

    public ICollection<ProfileCourses> ProfileCourses { get; set; }
  }
}

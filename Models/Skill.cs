using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Skill
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
  }
}

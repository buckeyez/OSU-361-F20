using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Skills
  {
    public int Id { get; set; }
    [Required]
    public string Skill { get; set; }
  }
}

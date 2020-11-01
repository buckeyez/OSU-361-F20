using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Title
  {
    public int Id { get; set; }
    [Required]
    public string Value { get; set; }
  }
}

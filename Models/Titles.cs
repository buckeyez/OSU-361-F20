using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Titles
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
  }
}

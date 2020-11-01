using System.ComponentModel.DataAnnotations;

namespace ExpertFinder.Models
{
  public class Users
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
  }
}

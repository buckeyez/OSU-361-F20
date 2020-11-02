namespace ExpertFinder.Models
{
  public class ProfileSkills
  {
    public int ProfileId { get; set; }
    public Profile Profile { get; set; }
    public int SkillId { get; set; }
    public Skill Skill { get; set; }
  }
}

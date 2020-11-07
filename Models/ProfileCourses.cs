namespace ExpertFinder.Models
{
  public class ProfileCourses
  {
    public int ProfileId { get; set; }
    public Profile Profile { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
  }
}

using ExpertFinder.Data;
using ExpertFinder.Models;
using System.Linq;

namespace ExpertFinder.DummyData
{
  public static class DummyData
  {
    public static void AddDummyData(AppDbContext dbContext)
    {
      // follow this paradigm when adding dummy data
      // check that it does not exist, then add what you need and save it
      var usersExist = dbContext.Users.Any();
      if (!usersExist)
      {
        dbContext.Add(new Users { Name = "mason", Email = "reiseltc@oregonstate.edu" });
        dbContext.Add(new Users { Name = "john smith", Email = "smithj@oregonstate.edu" });
      }

      var titlesExist = dbContext.Titles.Any();
      if (!titlesExist)
      {
        dbContext.Add(new Titles { Title = "Mr." });
        dbContext.Add(new Titles { Title = "Ms." });
      }

      var skillsExist = dbContext.Skills.Any();
      if (!skillsExist)
      {
        dbContext.Add(new Skills { Skill = "c++" });
        dbContext.Add(new Skills { Skill = ".net" });
        dbContext.Add(new Skills { Skill = "js" });
      }

      dbContext.SaveChanges();

      var profilesExist = dbContext.Profiles.Any();
      if (!profilesExist)
      {
        dbContext.Add(new Profile { FirstName = "Mason", LastName = "Reiselt", Title = dbContext.Titles.Where(t => t.Title == "Mr.").First() });
      }

      dbContext.SaveChanges();
    }
  }
}

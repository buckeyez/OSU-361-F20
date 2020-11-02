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
        dbContext.Add(new User { Name = "mason", Email = "reiseltc@oregonstate.edu" });
        dbContext.Add(new User { Name = "john smith", Email = "smithj@oregonstate.edu" });
      }

      var titlesExist = dbContext.Titles.Any();
      if (!titlesExist)
      {
        dbContext.Add(new Title { Value = "Mr." });
        dbContext.Add(new Title { Value = "Ms." });
      }

      var skillsExist = dbContext.Skills.Any();
      if (!skillsExist)
      {
        dbContext.Add(new Skill { Name = "c++" });
        dbContext.Add(new Skill { Name = ".net" });
        dbContext.Add(new Skill { Name = "js" });
      }

      dbContext.SaveChanges();

      var profilesExist = dbContext.Profiles.Any();
      if (!profilesExist)
      {
        dbContext.Add(new Profile
        {
          FirstName = "Mason",
          LastName = "Reiselt",
          Title = dbContext.Titles
            .Where(t => t.Value == "Mr.")
            .First()
        });
      }

      dbContext.SaveChanges();

      var hasProfileSkillsMapping = dbContext.ProfileSkills.Any();
      if (!hasProfileSkillsMapping)
      {
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 1 });
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 2 });
      }

      dbContext.SaveChanges();
    }
  }
}

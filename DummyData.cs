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
      var userExists = dbContext.Users
        .Where(u => u.Name == "mason")
        .FirstOrDefault();

      if (userExists == null)
      {
        dbContext.Add(new Users { Name = "mason", Email = "reiseltc@oregonstate.edu" });
        dbContext.SaveChanges();
      }

      userExists = dbContext.Users
        .Where(u => u.Name == "john smith")
        .FirstOrDefault();

      if (userExists == null)
      {
        dbContext.Add(new Users { Name = "john smith", Email = "smithj@oregonstate.edu" });
        dbContext.SaveChanges();
      }
    }
  }
}

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
      }

      var titlesExist = dbContext.Titles.Any();
      if (!titlesExist)
      {
        dbContext.Add(new Title { Value = "Mr." });
        dbContext.Add(new Title { Value = "Ms." });
        dbContext.Add(new Title { Value = "Mrs." });
        dbContext.Add(new Title { Value = "PhD" });
      }

      var skillsExist = dbContext.Skills.Any();
      if (!skillsExist)
      {
        dbContext.Add(new Skill { Name = ".NET" });
        dbContext.Add(new Skill { Name = "AJAX" });
        dbContext.Add(new Skill { Name = "ASP.NET" });
        dbContext.Add(new Skill { Name = "c" });
        dbContext.Add(new Skill { Name = "c#" });
        dbContext.Add(new Skill { Name = "c++" });
        dbContext.Add(new Skill { Name = "Git" });
        dbContext.Add(new Skill { Name = "HTML" });
        dbContext.Add(new Skill { Name = "Java" });
        dbContext.Add(new Skill { Name = "JavaScript" });
        dbContext.Add(new Skill { Name = "Linux" });
        dbContext.Add(new Skill { Name = "Oracle" });
        dbContext.Add(new Skill { Name = "Perl" });
        dbContext.Add(new Skill { Name = "PHP" });
        dbContext.Add(new Skill { Name = "Python" });
        dbContext.Add(new Skill { Name = "Ruby" });
        dbContext.Add(new Skill { Name = "SQL" });
        dbContext.Add(new Skill { Name = "TypeScript" });
        dbContext.Add(new Skill { Name = "UNIX" });
        dbContext.Add(new Skill { Name = "XML" });
      }

      var coursesExist = dbContext.Courses.Any();
      if (!coursesExist)
      {
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 101, Name = "Computers: Applications and Implications" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 160, Name = "Computer Science Orientation" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 161, Name = "Introduction to Computer Science I" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 162, Name = "Introduction to Computer Science II" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 201, Name = "Computer Programming for Non-cs Majors" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 225, Name = "Discrete Structures in Computer Science" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 261, Name = "Data Structures" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 271, Name = "Computer Architecture and Assembly Language" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 290, Name = "Web Development" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 321, Name = "Introduction to Theory of Computation" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 325, Name = "Analysis of Algorithms" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 340, Name = "Introduction to Databases" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 344, Name = "Operating Systems I" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 352, Name = "Introduction to Usability Engineering" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 361, Name = "Software Engineering I" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 362, Name = "Software Engineering II" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 370, Name = "Introduction to Security" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 372, Name = "Introduction to Computer Networks" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 373, Name = "Defense Against the Dark Arts" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 381, Name = "Programming Language Fundamentals" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 391, Name = "Social and Ethical Issues in Computer Science " });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 406, Name = "Projects" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 427, Name = "Cryptography" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 444, Name = "Operating Systems II" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 450, Name = "Introduction to Computer Graphics" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 461, Name = "Senior Software Engineering Project I" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 462, Name = "Senior Software Engineering Project II" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 464, Name = "Open Source Software" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 467, Name = "Online Capstone Project" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 475, Name = "Introduction to Parallel Programming" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 477, Name = "Introduction to Digital Forensics" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 478, Name = "Network Security" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 492, Name = "Mobile Software Development" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 493, Name = "Cloud Application Development" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 510, Name = "Occupational Internship" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 511, Name = "Programming and Data Structures" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 512, Name = "Data Science Tools and Programming" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 519, Name = "Selected Topics in Computer Science" });
        dbContext.Add(new Course { NumberPrefix = "CS", Number = 575, Name = "Introduction to Parallel Programming" });
      }

      dbContext.SaveChanges();

      var profilesExist = dbContext.Profiles.Any();
      if (!profilesExist)
      {
        var mrTitle = dbContext.Titles.Where(t => t.Value == "Mr.").First();
        var msTitle = dbContext.Titles.Where(t => t.Value == "Ms.").First();
        var mrsTitle = dbContext.Titles.Where(t => t.Value == "Mrs.").First();
        var phdTitle = dbContext.Titles.Where(t => t.Value == "PhD").First();

        dbContext.Add(new Profile
        {
          FirstName = "Tony",
          LastName = "Stark",
          Title = phdTitle,
          Email = "tony.stark@avengers.com",
          Organization = "Stark Industries",
          Biography = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In imperdiet nunc ac erat
          placerat, sed pellentesque tortor finibus. Praesent quis facilisis nunc, varius maximus
          nunc. Nulla maximus interdum justo sit amet lacinia. Suspendisse vitae semper mauris.
          Praesent elementum luctus aliquam. Aenean luctus suscipit erat vel dictum. Nullam eleifend
          massa sed mi efficitur, ut rhoncus felis posuere. Sed non maximus augue, at consequat
          lorem. Ut fermentum sit amet sem eget mattis. Etiam cursus mauris non ante consectetur, a
          faucibus lectus porta. Vestibulum sit amet porttitor nulla.",
          Picture = "https://vignette.wikia.nocookie.net/marvelhigh/images/8/8c/Tony_Stark.jpg/revision/latest?cb=20180331224523"
        });

        dbContext.Add(new Profile
        {
          FirstName = "Bill",
          LastName = "Gates",
          Title = mrTitle,
          Email = "bill.gates@microsoft.com",
          Organization = "Microsoft",
          LinkedIn = "https://www.linkedin.com/in/williamhgates/",
          GitHub = "microsoft",
          Biography = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In imperdiet nunc ac erat
          placerat, sed pellentesque tortor finibus. Praesent quis facilisis nunc, varius maximus
          nunc. Nulla maximus interdum justo sit amet lacinia. Suspendisse vitae semper mauris.
          Praesent elementum luctus aliquam. Aenean luctus suscipit erat vel dictum. Nullam eleifend
          massa sed mi efficitur, ut rhoncus felis posuere. Sed non maximus augue, at consequat
          lorem. Ut fermentum sit amet sem eget mattis. Etiam cursus mauris non ante consectetur, a
          faucibus lectus porta. Vestibulum sit amet porttitor nulla.",
          Picture = "https://api.time.com/wp-content/uploads/2018/09/bill-gates-africa.jpg"
        });

        dbContext.Add(new Profile
        {
          FirstName = "Jeff",
          LastName = "Bezos",
          Title = mrTitle,
          Email = "jeff.bezos@amazon.com",
          Organization = "Amazon",
          Biography = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In imperdiet nunc ac erat
          placerat, sed pellentesque tortor finibus. Praesent quis facilisis nunc, varius maximus
          nunc. Nulla maximus interdum justo sit amet lacinia. Suspendisse vitae semper mauris.
          Praesent elementum luctus aliquam. Aenean luctus suscipit erat vel dictum. Nullam eleifend
          massa sed mi efficitur, ut rhoncus felis posuere. Sed non maximus augue, at consequat
          lorem. Ut fermentum sit amet sem eget mattis. Etiam cursus mauris non ante consectetur, a
          faucibus lectus porta. Vestibulum sit amet porttitor nulla.",
          Picture = "https://specials-images.forbesimg.com/imageserve/5fa341fc79e490dbc4d29ff4/960x0.jpg?fit=scale"
        });
      }

      dbContext.SaveChanges();

      var hasProfileSkillsMapping = dbContext.ProfileSkills.Any();
      if (!hasProfileSkillsMapping)
      {
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 1 });
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 2 });
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 3 });
        dbContext.Add(new ProfileSkills { ProfileId = 1, SkillId = 4 });
        dbContext.Add(new ProfileSkills { ProfileId = 2, SkillId = 5 });
        dbContext.Add(new ProfileSkills { ProfileId = 2, SkillId = 6 });
        dbContext.Add(new ProfileSkills { ProfileId = 2, SkillId = 7 });
        dbContext.Add(new ProfileSkills { ProfileId = 2, SkillId = 8 });
        dbContext.Add(new ProfileSkills { ProfileId = 3, SkillId = 9 });
        dbContext.Add(new ProfileSkills { ProfileId = 3, SkillId = 10 });
        dbContext.Add(new ProfileSkills { ProfileId = 3, SkillId = 11 });
        dbContext.Add(new ProfileSkills { ProfileId = 3, SkillId = 12 });
      }

      var hasProfileCoursesMapping = dbContext.ProfileCourses.Any();
      if (!hasProfileCoursesMapping)
      {
        dbContext.Add(new ProfileCourses { ProfileId = 1, CourseId = 1 });
        dbContext.Add(new ProfileCourses { ProfileId = 1, CourseId = 2 });
        dbContext.Add(new ProfileCourses { ProfileId = 1, CourseId = 3 });
        dbContext.Add(new ProfileCourses { ProfileId = 1, CourseId = 4 });
        dbContext.Add(new ProfileCourses { ProfileId = 2, CourseId = 5 });
        dbContext.Add(new ProfileCourses { ProfileId = 2, CourseId = 6 });
        dbContext.Add(new ProfileCourses { ProfileId = 2, CourseId = 7 });
        dbContext.Add(new ProfileCourses { ProfileId = 2, CourseId = 8 });
        dbContext.Add(new ProfileCourses { ProfileId = 3, CourseId = 9 });
        dbContext.Add(new ProfileCourses { ProfileId = 3, CourseId = 10 });
        dbContext.Add(new ProfileCourses { ProfileId = 3, CourseId = 11 });
        dbContext.Add(new ProfileCourses { ProfileId = 3, CourseId = 12 });
      }

      dbContext.SaveChanges();
    }
  }
}

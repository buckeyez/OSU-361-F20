using ExpertFinder.Data;
using ExpertFinder.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExpertFinder
{
  public class Startup
  {
    private IConfiguration _config;

    public Startup(IConfiguration config)
    {
      _config = config;
    }
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<AppDbContext>(options =>
      {
        options.UseSqlite("Data Source=ef.db");
      });

      services.AddMvc();

      AddRepositories(services);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();

        app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
        {
          HotModuleReplacement = true
        });
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }

    private void AddRepositories(IServiceCollection services)
    {
      services.AddTransient<ICourseRepo, CourseRepo>();
      services.AddTransient<IProfileRepo, ProfileRepo>();
      services.AddTransient<IProfileCoursesRepo, ProfileCoursesRepo>();
      services.AddTransient<IProfileSkillsRepo, ProfileSkillsRepo>();
      services.AddTransient<ISkillRepo, SkillRepo>();
      services.AddTransient<ITitleRepo, TitleRepo>();
      services.AddTransient<IUserRepo, UserRepo>();
    }
  }
}

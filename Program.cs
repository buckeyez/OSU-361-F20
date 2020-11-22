using ExpertFinder.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
namespace ExpertFinder
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      using var Host = CreateHostBuilder(args).Build();
      using var cancelSource = new CancellationTokenSource();

      using (var scope = Host.Services.CreateScope())
      {
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        DummyData.DummyData.AddDummyData(dbContext);
      }

      await Host.RunAsync(cancelSource.Token);
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
          webBuilder.UseUrls("http://localhost:8080");
          webBuilder.UseStartup<Startup>();
        })
        .ConfigureLogging((context, logging) =>
        {
          logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.None);
          logging.AddFilter("Microsoft.EntityFrameworkCore.Update", LogLevel.None);
        });
  }
}

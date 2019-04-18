using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using TestProject.Data;

namespace TestProject
{
  public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarDbContext>
  {
    public CarDbContext CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<CarDbContext>();

      builder.UseSqlServer(configuration["Data:Products:ConnectionString"],
        b =>
        {
          b.MigrationsAssembly("TestProject");
        });

      return new CarDbContext(builder.Options);
    }
  }
}

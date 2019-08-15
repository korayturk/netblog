using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NetBLog.Data
{
    public class NetBLogDbContextFactory : IDesignTimeDbContextFactory<NetBLogDbContext>
    {
        public NetBLogDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString(nameof(NetBLogDbContext)));
            return new NetBLogDbContext(optionsBuilder.Options);
        }
    }
}

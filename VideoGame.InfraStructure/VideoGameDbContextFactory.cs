using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame.InfraStructure
{
    public class VideoGameDbContextFactory : IDesignTimeDbContextFactory<VideoGameDbContext>
    {
        public VideoGameDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VideoGameDbContext>();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new VideoGameDbContext(optionsBuilder.Options);

        }
    }
}

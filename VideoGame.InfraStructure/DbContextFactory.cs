using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VideoGame.Application.Interfaces;

namespace VideoGame.InfraStructure
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly IConfiguration _configuration;

        public DbContextFactory(IConfiguration configuration)
        {
           _configuration = configuration;
        }

        public VideoGameDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<VideoGameDbContext>();

            var provider = _configuration.GetSection("DatabaseProvider");
            if(provider.Value == "SqlServer")
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection"));
            }
            else if(provider.Value == "PostgreSQL")
            {
                //use postgre sql
            }
            else
            {
                throw new Exception("Unsupported database provider");
            }

            return new VideoGameDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace VideoGame.InfraStructure
{
    public interface IDbContextFactory
    {
        VideoGameDbContext CreateDbContext();
    }
}

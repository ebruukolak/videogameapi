using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGame.Application.Interfaces;
using VideoGame.Domain.Entities;

namespace VideoGame.InfraStructure
{
    public class VideoGameDbContext:DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options):base(options)
        {
        }

        public DbSet<VideoGamee> VideoGames => Set<VideoGamee>();
    }
}

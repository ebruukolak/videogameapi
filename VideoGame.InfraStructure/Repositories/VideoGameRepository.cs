using VideoGame.Application.Interfaces;
using VideoGame.Domain.Entities;

namespace VideoGame.InfraStructure.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly VideoGameDbContext _dbContext;

        public VideoGameRepository(IDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }


        public VideoGamee GetVideoGameeById(int id)
        {
            var videoGame = _dbContext.VideoGames.FirstOrDefault(x => x.Id == id);
            return videoGame;
        }

        public VideoGamee AddVideoGamee(VideoGamee videoGame)
        {
            _dbContext.VideoGames.Add(videoGame);
            _dbContext.SaveChanges();
            return videoGame;
        }



        public List<VideoGamee> GetAll()
        {
            return _dbContext.VideoGames.ToList();
        }



        public bool UpdateVideoGamee(VideoGamee videoGamee)
        {
            var game = _dbContext.VideoGames.Find(videoGamee.Id);
            if (game is null)
                return false;

            game.Title = videoGamee.Title;
            game.PublisherId = videoGamee.PublisherId;
            game.DeveloperId = videoGamee.DeveloperId;
            game.Platform = videoGamee.Platform;

            _dbContext.SaveChanges();

            return true;


        }

        public bool DeleteVideoGamee(int id)
        {
            var game = _dbContext.VideoGames.Find(id);
            if (game is null)
                return false;

            _dbContext.Remove(game);
            _dbContext.SaveChanges();
            return true;
        }
    }
}

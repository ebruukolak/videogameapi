using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGame.Domain.Entities;

namespace VideoGame.Application.Interfaces
{
    public interface IVideoGameRepository
    {
        VideoGamee AddVideoGamee(VideoGamee videoGame);
        VideoGamee GetVideoGameeById(int id);
        List<VideoGamee> GetAll();
        bool UpdateVideoGamee(VideoGamee videoGamee);
        bool DeleteVideoGamee(int id);
    }
}

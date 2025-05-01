using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGame.Application.DTOs;
using VideoGame.Domain.Entities;

namespace VideoGame.Application.Interfaces
{
    public interface IVideoGameService
    {
        VideoGameDTO AddVideoGame(VideoGameDTO videoGame);
        VideoGameDTO GetVideoGameById(int id);
        List<VideoGameDTO> GetAll();
        bool UpdateVideoGame(VideoGameDTO videoGameDTO);
        bool DeleteVideoGame(int id);

    }
}

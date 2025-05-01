using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGame.Application.DTOs;
using VideoGame.Application.Interfaces;
using VideoGame.Application.Mapping;
using VideoGame.Domain.Entities;

namespace VideoGame.Application.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public VideoGameService(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public VideoGameDTO AddVideoGame(VideoGameDTO videoGame)
        {
            var game = videoGame.MaptoVideoGamee();
            var newGame = _videoGameRepository.AddVideoGamee(game);
            return newGame.MaptoVideoGameDTO();
        }

        public bool DeleteVideoGame(int id)
        {
            return _videoGameRepository.DeleteVideoGamee(id);
        }

        public List<VideoGameDTO> GetAll()
        {
            return _videoGameRepository.GetAll()
                   .Select(s=> s.MaptoVideoGameDTO())
                   .ToList();
        }

        public VideoGameDTO GetVideoGameById(int id)
        {
            var game = _videoGameRepository.GetVideoGameeById(id);
            return game.MaptoVideoGameDTO();
        }

        public bool UpdateVideoGame(VideoGameDTO videoGameDTO)
        {
            var game = videoGameDTO.MaptoVideoGamee();
            return _videoGameRepository.UpdateVideoGamee(game);
        }
    }
}

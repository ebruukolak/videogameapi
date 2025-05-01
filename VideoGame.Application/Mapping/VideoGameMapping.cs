using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGame.Application.DTOs;
using VideoGame.Domain.Entities;

namespace VideoGame.Application.Mapping
{
    public static class VideoGameMapping
    {
        public static VideoGamee MaptoVideoGamee(this VideoGameDTO videoGameDTO)
        {
            return new VideoGamee
            {
                Id = videoGameDTO.Id,
                DeveloperId = videoGameDTO.DeveloperId,
                Platform = videoGameDTO.Platform,
                PublisherId = videoGameDTO.PublisherId,
                Title = videoGameDTO.Title,
            };
        }

        public static VideoGameDTO MaptoVideoGameDTO(this VideoGamee videoGame)
        {
            return new VideoGameDTO
            {
                Id = videoGame.Id,
                DeveloperId = videoGame.DeveloperId,
                Platform = videoGame.Platform,
                PublisherId = videoGame.PublisherId,
                Title = videoGame.Title,
            };
        }
    }
}

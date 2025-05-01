using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGame.Application.DTOs;
using VideoGame.Application.Interfaces;
using VideoGame.Domain.Entities;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly IVideoGameService _videoGameService;

        public VideoGameController(IVideoGameService videoGameService)
        {
           _videoGameService = videoGameService;
        }

        [HttpGet("{id}")]
        public ActionResult<VideoGameDTO> GetVideoGameById(int id)
        {
             var game = _videoGameService.GetVideoGameById(id);
            if(game is null )
                return NotFound();
            return Ok(game);
        }

        [HttpGet]
        public ActionResult<List<VideoGameDTO>> GetVideoGames()
        {
            var games = _videoGameService.GetAll();
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddVideoGame(VideoGameDTO newGame)
        {
            if (newGame is null)
                return BadRequest();
           var createdGame = _videoGameService.AddVideoGame(newGame);

            return CreatedAtAction(nameof(GetVideoGameById), newGame, new {id=createdGame.Id});
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideoGame(VideoGameDTO videoGame,int id)
        {
            videoGame.Id = id;
            var isUpdated = _videoGameService.UpdateVideoGame(videoGame);
            if(!isUpdated)
                return BadRequest();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideoGame(int id) 
        { 
            var isDeleted = _videoGameService.DeleteVideoGame(id);

            if(!isDeleted)
                return BadRequest();

            return NoContent();
        }
    }
}

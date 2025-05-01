using Moq;
using VideoGame.Application.Interfaces;
using VideoGame.Application.Services;
using FluentAssertions;
using VideoGame.Domain.Entities;

namespace VideoGame.Tests
{
    public class VideoGameServiceTest
    {
        private Mock<IVideoGameRepository> _mockRepo;
        private VideoGameService _service;


        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IVideoGameRepository>();
            _service = new VideoGameService(_mockRepo.Object);
        }


        [Test]
        public void GetVideoGameById_ReturnsGame_WhenGameExists()
        {
            _mockRepo.Setup(r => r.GetVideoGameeById(1))
                .Returns(new VideoGamee { Id = 1, Title = "test" });


            var result = _service.GetVideoGameById(1);

            result.Should().NotBeNull();
            result.Title.Should().Be("test");
            result.Id.Should().Be(1);
        }

        [Test]

        public void AddVideoGame_WithValidData_ReturnsCreatedVideoGame()
        {
            var videoGame = new VideoGamee { Id = 2, Title = "new game" };

            var videoGameDto = new Application.DTOs.VideoGameDTO { Id = videoGame.Id, Title = videoGame.Title };


            _mockRepo.Setup(r => r.AddVideoGamee(It.IsAny<VideoGamee>()))
                .Returns(videoGame);

           var result = _service.AddVideoGame(videoGameDto);

            result.Should().NotBeNull();
            result.Id.Should().Be(2);
        }

        [Test]
        public void UpdateVideoGame_WithValidData_ReturnsTrue()
        {
            var  updatedVideoGame = new Application.DTOs.VideoGameDTO { Id = 2, Title = "new game" };

            _mockRepo.Setup(r => r.UpdateVideoGamee(It.IsAny<VideoGamee>()))
                .Returns(true);
            var result = _service.UpdateVideoGame(updatedVideoGame);

            result.Should().BeTrue();
        }

        [Test]
        public void DeleteVideoGame_WhenExists()
        {
            _mockRepo.Setup(r=>r.DeleteVideoGamee(1)).Returns(true);
            var result = _service.DeleteVideoGame(1);
            result.Should().BeTrue();
        }

    }
}

using GameOfLife.Context;
using GameOfLife.Models;
using GameOfLife.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameOfLife.Controllers
{
    [Route("GameOfLife")]
    [ApiController]
    public class GameOfLifeController : ControllerBase
    {
        public IHumanRepository _repository;
        public GameOfLifeController(IHumanRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("AddHuman")]
        public async Task<IActionResult> AddHuman(string humanName)
        {
            var human = new Human(humanName);
            Response response = _repository.AddHuman(human);


            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description
                });
            }
        }

        [HttpDelete("DeleteHuman")]
        public async Task<IActionResult> DeleteHuman(string humanId)
        {
            Response response = _repository.DeleteHuman(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description
                });
            }
        }
    }
}

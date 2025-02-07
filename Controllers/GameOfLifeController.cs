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
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
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
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("DoEngineering")]
        public async Task<IActionResult> DoEngineering(string humanId)
        {
            Response response = _repository.DoEngineering(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("GoToSleep")]
        public async Task<IActionResult> GoToSleep(string humanId)
        {
            Response response = _repository.GoToSleep(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("Eat")]
        public async Task<IActionResult> Eat(string humanId)
        {
            Response response = _repository.Eat(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("PlayPS5")]
        public async Task<IActionResult> PlayPS5(string humanId)
        {
            Response response = _repository.PlayPS5(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("ReadABook")]
        public async Task<IActionResult> ReadABook(string humanId)
        {
            Response response = _repository.ReadABook(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

        [HttpPost("FitnessTraining")]
        public async Task<IActionResult> FitnessTraining(string humanId)
        {
            Response response = _repository.FitnessTraining(humanId);
            if (response.Success)
            {
                return Ok(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = response.Success,
                    Message = response.Message,
                    Description = response.Description,
                    Human = response.Human
                });
            }
        }

    }
}

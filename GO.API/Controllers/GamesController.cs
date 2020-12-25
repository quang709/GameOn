using GO.BAL.Interface;
using GO.Domain.Request.Games;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GO.API.Controllers
{
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService gameService;

        public GamesController(IGameService gameService)
        {
            this.gameService = gameService;
        }
        [HttpGet]
        [Route("/api/game/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await gameService.Gets());
        }

        [HttpPost]
        [Route("/api/game/create")]
        public async Task<OkObjectResult> Create(CreateGameRequest request)
        {
            return Ok(await gameService.CreateGame(request));
        }

        [HttpPost]
        [Route("/api/game/update")]
        public async Task<OkObjectResult> Update(UpdateGameRequest request)
        {
            return Ok(await gameService.UpdateGame(request));
        }
        [HttpDelete]
        [Route("/api/game/delete")]
        public async Task<OkObjectResult> Delete(DeleteGameRequest request)
        {
            return Ok(await gameService.DeleteGame(request));
        }
    }
}

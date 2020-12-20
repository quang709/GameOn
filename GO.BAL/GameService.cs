using GO.BAL.Interface;
using GO.DAL.Interface;
using GO.Domain.Request.Games;
using GO.Domain.Response.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL
{
    public class GameService : IGameService
    {
        private readonly IGameRepository gameRepository;
        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public async Task<CreateGameResult> CreateGame(CreateGameRequest request)
        {
            return await gameRepository.CreateGame(request);
        }

        public async Task<DeleteGameResult> DeleteGame(DeleteGameRequest request)
        {
            return await gameRepository.DeleteGame(request);
        }

        public async Task<IEnumerable<Games>> Gets()
        {
            return await gameRepository.Gets();
        }

        public async Task<UpdateGameResult> UpdateGame(UpdateGameRequest request)
        {
            return await gameRepository.UpdateGame(request);
        }
    }
}

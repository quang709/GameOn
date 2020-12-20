using GO.Domain.Request.Games;
using GO.Domain.Response.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL.Interface
{
    public interface IGameService
    {
        Task<IEnumerable<Games>> Gets();

        Task<CreateGameResult> CreateGame(CreateGameRequest request);

        Task<UpdateGameResult> UpdateGame(UpdateGameRequest request);

        Task<DeleteGameResult> DeleteGame(DeleteGameRequest request);
    }
}

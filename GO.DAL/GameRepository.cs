using Dapper;
using GO.DAL.Interface;
using GO.Domain.Request.Games;
using GO.Domain.Response.Games;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GO.DAL
{
    public class GameRepository : BaseRepository, IGameRepository
    {
        public async Task<CreateGameResult> CreateGame(CreateGameRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GameName", request.GameName);
                parameters.Add("@Gameplay", request.Gameplay);
                parameters.Add("@Conclusion", request.Conclusion);
                parameters.Add("@Image", request.Image);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Graphics", request.Graphics);
                parameters.Add("@Levels", request.Levels);
                parameters.Add("@Dificulty", request.Dificulty);
                parameters.Add("@Testimonials", request.Testimonials);
                parameters.Add("@IdCategory", request.IdCategory);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateGameResult>(cnn: connect,
                                                    sql: "sp_CreateGame",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteGameResult> DeleteGame(DeleteGameRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IdGame", request.IdGame);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteGameResult>(cnn: connect,
                                                    sql: "sp_DeleteGame",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Games>> Gets()
        {
            return await SqlMapper.QueryAsync<Games>(cnn: connect,
                                                sql: "sp_GetGames",
                                                commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateGameResult> UpdateGame(UpdateGameRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IdGame", request.IdGame);
                parameters.Add("@GameName", request.GameName);
                parameters.Add("@Gameplay", request.Gameplay);
                parameters.Add("@Conclusion", request.Conclusion);
                parameters.Add("@Image", request.Image);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Graphics", request.Graphics);
                parameters.Add("@Levels", request.Levels);
                parameters.Add("@Dificulty", request.Dificulty);
                parameters.Add("@Testimonials", request.Testimonials);
                parameters.Add("@IdCategory", request.IdCategory);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateGameResult>(cnn: connect,
                                                    sql: "sp_UpdateGame",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;

            }
        }
    }
}

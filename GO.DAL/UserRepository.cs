using Dapper;
using GO.DAL.Interface;
using GO.Domain.Request.User;
using GO.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GO.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public async Task<UserLoginResult> UserLogin(UserLoginRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Username", request.Username);
                parameters.Add("@Password", request.Password);
                return await SqlMapper.QueryFirstOrDefaultAsync<UserLoginResult>(cnn: connect,
                                                    sql: "sp_UserLogin",
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

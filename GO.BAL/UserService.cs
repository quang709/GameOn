using GO.BAL.Interface;
using GO.DAL.Interface;
using GO.Domain.Request.User;
using GO.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<UserLoginResult> UserLogin(UserLoginRequest request)
        {
            return await userRepository.UserLogin(request);
        }
    }
}

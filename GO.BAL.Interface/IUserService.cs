using GO.Domain.Request.User;
using GO.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL.Interface
{
    public interface IUserService
    {
        Task<UserLoginResult> UserLogin(UserLoginRequest request);
    }
}

using GO.Domain.Request.User;
using GO.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.DAL.Interface
{
    public interface IUserRepository
    {
        Task<UserLoginResult> UserLogin(UserLoginRequest request);
    }
}

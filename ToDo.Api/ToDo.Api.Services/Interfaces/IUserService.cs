using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.Models;

namespace ToDo.Api.Services.Interfaces
{
    public interface IUserService
    {
        UserModel Authenticate(string username, string password);
        void Register(RegisterModel request);
    }
}

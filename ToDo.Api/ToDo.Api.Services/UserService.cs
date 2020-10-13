using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ToDo.Api.DataAccess;
using ToDo.Api.DataModels.DbModels;
using ToDo.Api.Models;
using ToDo.Api.Services.Exceptions;
using ToDo.Api.Services.Interfaces;

namespace ToDo.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository )
        {
            _userRepository = userRepository;
        }
        public UserModel Authenticate(string username, string password)
        {
            var user = _userRepository.GetAll().FirstOrDefault(x =>
                    x.UserName == username);

            if (user == null)
            {
                throw new UserException(null, null,
                    "User with that username does not exists");
            }

            var hashedPasword = HashPassword(password);
            if (user.Password != hashedPasword)
            {
                throw new UserException(user.Id, user.Password,
                    "Password does not match with user password");
            }


            var userModel = new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,

            };

            return userModel;
        }

        public void Register(RegisterModel request)
        {
            if (string.IsNullOrWhiteSpace(request.Password) ||
                string.IsNullOrWhiteSpace(request.ConfirmPassword))
            {
                throw new UserException(null, request.Password,
                    "Password is required");
            }

            if (request.Password != request.ConfirmPassword)
            {
                throw new UserException(null, request.Password,
                    "Passwords does not match");
            }

            if (string.IsNullOrWhiteSpace(request.FullName))
            {
                throw new UserException(null, request.FullName,
                    "Fullname is required"); 
            }

            if (string.IsNullOrWhiteSpace(request.Username))
            {
                throw new UserException(null, request.Username,
                    "Username is required");
            }

            var hashedPassword = HashPassword(request.Password);

            var user = new User
            {
                FullName = request.FullName,
                UserName = request.Username,
                Password = hashedPassword
            };

            _userRepository.Create(user);
        }

        private string HashPassword(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Encoding.ASCII.GetString(md5data);
        }
    }
}

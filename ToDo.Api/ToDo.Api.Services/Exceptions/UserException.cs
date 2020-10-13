using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Services.Exceptions
{
    public class UserException : Exception
    {
        public int? UserId { get; set; }
        public string FullName { get; set; }

        public UserException(int? userId, string name)
            : base("There has been a problem with a user")
        {
            UserId = userId;
            FullName = name;
        }

        public UserException(int? userId, string name, string message)
            : base(message)
        {
            UserId = userId;
            FullName = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Models
{
    public class RegisterModel
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

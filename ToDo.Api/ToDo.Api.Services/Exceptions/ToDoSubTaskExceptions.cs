using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Services.Exceptions
{
    public class ToDoSubTaskExceptions : Exception
    {
        public ToDoSubTaskExceptions(string message)
            : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Services.Exceptions
{
    public class ToDoTaskException : Exception
    {
        public ToDoTaskException(string message)
            : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Api.Models;
using ToDo.Api.Services.Exceptions;
using ToDo.Api.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDo.Api.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTaskController : ControllerBase
    {
        private readonly IToDoTaskService _toDoService;

        public ToDoTaskController(IToDoTaskService toDoService)
        {
            _toDoService = toDoService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ToDoTaskModel>> Get([FromQuery] int id)
        {
            try
            {
                return Ok(_toDoService.GetUserTodos(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult<ToDoTaskModel> Get(int id, [FromQuery] int userId)
        {
            try
            {
                return Ok(_toDoService.GetTask(id, userId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] ToDoTaskModel request)
        {
            try
            {
                _toDoService.AddTask(request);
                return Ok("Success");
            }
            catch (ToDoTaskException ex)
            {
                Debug.WriteLine($"TODO:{ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"TODO:{ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id, [FromQuery] int userId)
        {
            try
            {
                _toDoService.DeleteTask(id, userId);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

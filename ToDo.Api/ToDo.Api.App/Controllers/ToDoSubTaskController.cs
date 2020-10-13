using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Api.Models;
using ToDo.Api.Services.Exceptions;
using ToDo.Api.Services.Interfaces;

namespace ToDo.Api.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoSubTaskController : ControllerBase
    {
        private readonly IToDoSubTaskService _subTaskService;

        public ToDoSubTaskController(IToDoSubTaskService subTaskService)
        {
            _subTaskService = subTaskService;
        }

        public ActionResult<IEnumerable<SubTaskModel>> Get([FromQuery] int id)
        {
            try
            {
                return Ok(_subTaskService.GetTodoSubTasks(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<SubTaskModel> Get(int id, [FromQuery] int userId)
        {
            try
            {
                return Ok(_subTaskService.GetSubTask(id, userId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] SubTaskModel request)
        {
            try
            {
                _subTaskService.AddSubTask(request);
                return Ok("Success");
            }
            catch (ToDoSubTaskExceptions ex)
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
                _subTaskService.DeleteSubTask(id, userId);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

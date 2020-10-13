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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public ActionResult<UserModel> Authenticate([FromBody] LoginModel request)
        {
            try
            {
                var response = _userService
                    .Authenticate(request.UserName, request.Password);

                Debug.WriteLine($"{response.Id} has been loged in");
                return Ok(response);
            }
            catch (UserException ex)
            {
                Debug.WriteLine($"USER: {ex.UserId}.{ex.FullName} {ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return BadRequest("Something went wrong!");
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel request)
        {
            try
            {
                _userService.Register(request);
                Debug.WriteLine($"User registered with {request.Username}");
                return Ok("Success");
            }
            catch (UserException ex)
            {
                Debug.WriteLine($"User {ex.UserId}.{ex.FullName}: {ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unknown error: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}

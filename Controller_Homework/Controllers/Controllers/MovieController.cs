using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Controllers_Exercise.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        //Create Movie controller that will have two actions.The first action should have a parameter of type DateTime and the second should have the parameter of type Boolean.The action end points should be available at urls:

        ///homework/movie/get-movies/2019-05-03

        ///homework/movie/get-available/true

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-movies/{date}")]
        public IActionResult GetMovieDate(DateTime date)
        {
            var movieDate = new
            {
                Date = date,
                IsPlaying = true
            };
            return Json(movieDate);
        }

        [HttpGet("get-available/{play}")]
        public IActionResult MoviePlaying(bool play)
        {
            var moviePlay = new
            {
                Date = "2019-05-03",
                IsPlaying = play
            };
            return Json(moviePlay);
        }
    }
}

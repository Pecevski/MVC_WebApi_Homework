using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Exercise.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/homework/movie/get-movies/{date}")]
        public IActionResult GetMovieDate(DateTime date)
        {
            var movieDate = new
            {
                Date = date,
                IsPlaying = true
            };
            return Json(movieDate);
        }

        [HttpGet("/homework/movie/get-available/{play}")]
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

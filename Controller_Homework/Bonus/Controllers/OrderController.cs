using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace Bonus.Controllers
{
    public class OrderController : Controller
    {
        //Create Order controller that will be able to create an order.After creating the order the user should be redirected to the /Home route.
        //Bonus: Action end points should be available at: /pizza/order/create-order/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet("pizza/order/create-order")]
        public IActionResult OrderById()
        {
           
            return View();
        }

        [HttpPost("pizza/order/create-order")]
        public IActionResult OrderById(int? order)
        {
            if (order.HasValue) return View();
            return RedirectToAction("Home");

        }
    }
}

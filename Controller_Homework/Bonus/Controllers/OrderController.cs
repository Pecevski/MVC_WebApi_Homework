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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet("/pizza/order/create-order/{id?}")]
        public IActionResult OrderById(string id)
        {
            var orderId = new
            {
                Name = "Pizza",
                Id = id
            };
            return Json(orderId);
        }

        [HttpGet("/pizza/order/Home")]
        public IActionResult OrderByName(int? id)
        {
            if (id.HasValue) return View();
            return RedirectToAction("Home");

        }
    }
}

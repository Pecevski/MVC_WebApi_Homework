using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Exercise.Controllers
{
    
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/product/get-product/{id}")]
        public IActionResult GetProductById(int id)
        {
            var productId = new
            {
                Name = "Shoes",
                Id = id

            };
            return View();
        }

        [HttpGet("/product/get-product/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            var productname = new
            {
                Name = name,
                Id = 3
            };
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Exercise.Controllers
{
    
    public class ProductController : Controller
    {
    //    Create Product controller that will have two action GetProductById(int id) and GetProductByName(string name). The action end points should be available at urls:

    //    /product/get-product/3

    //    /product/get-product/shoes


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("product/get-product/{id}")]
        public IActionResult GetProductById(int id)
        {
           
            return View();
        }

        [HttpGet("product/get-product/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesignPatern.Homework.App.Models;
using DesignPatern.Homework.BusinessLayer.Interfaces;
using DesignPatern.Homework.BusinessLayer.Services;
using DesignPatern.Homework.BusinessLayer.ViewModels;

namespace DesignPatern.Homework.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductServices _productServices;

        public HomeController()
        {
            _productServices = new ProductServices();
        }
        public IActionResult Index(string message)
        {
            ViewBag.Message = message;

            var productListVM = _productServices.Products();

            return View("Index", productListVM);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

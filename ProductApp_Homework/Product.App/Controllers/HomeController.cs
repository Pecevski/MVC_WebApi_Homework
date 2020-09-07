using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.App.DB;
using Products.App.Models;
using Products.App.Models.Domain;
using Products.App.Models.ViewModels;

namespace Products.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var productListVM = new List<ProductVM>();
            foreach (Product product in DataBase.Products)
            {
                var productVM1 = new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price
                };

                productListVM.Add(productVM1);
            }
            ProductListVM productVM = new ProductListVM()
            {
                NumberOfProducts = DataBase.Products.Count,
                Products = productListVM
            };
            return View("Index", productVM);
        }

    }
}

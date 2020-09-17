using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatern.Homework.BusinessLayer.Interfaces;
using DesignPatern.Homework.BusinessLayer.Services;
using DesignPatern.Homework.BusinessLayer.ViewModels;
using DesignPatern.Homework.DataLayer.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatern.Homework.App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductController()
        {
            _productServices = new ProductServices();
        }

        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductListVM createProduct)
        {

            var product = _productServices.CreateProduct(createProduct);
            //if (string.IsNullOrWhiteSpace(product.Name))
            //{
            //    return RedirectToAction("CreateProduct", new { error = "Product name is required!" });
            //}

            //if (string.IsNullOrWhiteSpace(product.Description))
            //{
            //    return RedirectToAction("CreateProduct", new { error = "Description is required!" });
            //}

            //if (product.Price == 0)
            //{
            //    return RedirectToAction("CreateProduct", new { error = "Price is required!" });
            //}


            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateProduct", new { error = "Product is not created, fields are required!" });
            }

            return RedirectToAction("Index", "Home", new { message = "Product was created!" });

        }
        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            var productVM = _productServices.GetProductDetails(id);

            return View("_PartialProductDetails", productVM);
        }
    }
}

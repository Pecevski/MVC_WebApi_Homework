using Microsoft.AspNetCore.Mvc;
using Products.App.Models.ViewModels;
using Products.App.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.App.DB;
using System.ComponentModel;

namespace Products.App.Controllers
{
    public class ProductController : Controller
    {
        
        //Creating product should have same route for Get and Post HttpMethod

        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        //When the user creates product should be redirected to see the products list and see an appropriate message if the product is created or not

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductListVM createProduct)
        {
            
            var product = new Product()
            {
                Id = DataBase.Products.Count + 1,
                Name = createProduct.Name,
                Price = createProduct.Price,
                Description = createProduct.Description,
                Category = createProduct.Category

            };

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return RedirectToAction("CreateProduct", new { error = "Product name is required!" });
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                return RedirectToAction("CreateProduct", new { error = "Description is required!" });
            }
           
            if (product.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "Price is required!" });
            }

            DataBase.Products.Add(product);
            return RedirectToAction("Index", "Home", new { message = "Product was created!" });
            
        }

        //The user should be able to see more details about a product

        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            var productListVM = new List<ProductVM>();
            
            foreach (Product product in DataBase.Products)
            {
                var productVM1 = new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    Price = product.Price
                };

                productListVM.Add(productVM1);
            }

            ProductVM productVM2 = productListVM.SingleOrDefault(p => p.Id == id);
            return View("_PartialProductDetails", productVM2);
        }


    }
}

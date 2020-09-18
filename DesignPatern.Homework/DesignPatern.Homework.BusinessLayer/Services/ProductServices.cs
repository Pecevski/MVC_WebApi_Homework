using DesignPatern.Homework.BusinessLayer.Interfaces;
using DesignPatern.Homework.BusinessLayer.ViewModels;
using DesignPatern.Homework.DataLayer;
using DesignPatern.Homework.DataLayer.DomainModels;
using DesignPatern.Homework.DataLayer.Interfaces;
using DesignPatern.Homework.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatern.Homework.BusinessLayer.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        
        public ProductServices()
        {
            _productRepository = new ProductRepository();
        }
        public ProductListVM Products()
        {
                                 
            List<ProductVM> productsList = new List<ProductVM>();
            foreach (Product product in _productRepository.GetProducts())
            {
                ProductVM productVM = new ProductVM()
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price       
                };
                productsList.Add(productVM);
                
            }

            ProductListVM productListVM = new ProductListVM();
            ProductListVM productVM1 = new ProductListVM()
            {
                NumberOfProducts = _productRepository.GetProducts().Count,
                Products = productsList
            };
            return productVM1;
            
        }

        public ProductVM CreateProduct(CreateProductListVM createProductVM)
        {
            return new ProductVM()
            {
                Id = _productRepository.GetProducts().Count + 1,
                Category = createProductVM.Category,
                Name = createProductVM.Name,
                Description = createProductVM.Description,
                Price = createProductVM.Price
            };
        }

        public ProductVM GetProductDetails(int id)
        {
        
             var productVM = _productRepository.GetProducts().Select(p => new ProductVM
             {
                 Id = p.Id,
                 Name = p.Name,
                 Description = p.Description,
                 Price = p.Price,
                 Category = p.Category
             });

            ProductVM productVM2 = productVM.SingleOrDefault(p => p.Id == id);
            return productVM2;
                
        }

    }
}

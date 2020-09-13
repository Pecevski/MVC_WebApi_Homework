using DesignPatern.Homework.BusinessLayer.Interfaces;
using DesignPatern.Homework.BusinessLayer.ViewModels;
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
        public List<ProductVM> Products()
        {
            //List<ProductVM> productListVM = new List<ProductVM>();
            //var productListVM1 = _productRepository.GetProducts().Select(p => new ProductVM { Id = p.Id, Name = p.Name});
            //productListVM.Add(productListVM1);
            //ProductListVM productVM = new ProductListVM()
            //{
            //    NumberOfProducts = _productRepository.GetProducts().Count,
            //    Products = productListVM
            //};
            //return productVM;

            List<ProductVM> listOfProductVM = new List<ProductVM>();

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
                listOfProductVM.Add(productVM);
            }

            return listOfProductVM;
        }

        public Product CreateProduct(CreateProductListVM createProduct)
        {
            List<ProductVM> productListVM = new List<ProductVM>();
            return new Product()
            {
                Id = _productRepository.GetProducts().Count + 1,
                Category = createProduct.Category,
                Name = createProduct.Name,
                Description = createProduct.Description,
                Price = createProduct.Price
            };

            //productListVM.Add(product);

            //return productListVM;

        }

        public Product GetProductDetails(int id)
        {
            var product = _productRepository.GetProducts().Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Category = p.Category
            });

            return product.SingleOrDefault(p => p.Id == id);
        }
    }
}

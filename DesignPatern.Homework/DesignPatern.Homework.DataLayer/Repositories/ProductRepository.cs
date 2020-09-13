using DesignPatern.Homework.DataLayer.DomainModels;
using DesignPatern.Homework.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatern.Homework.DataLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataBase _db;
        public ProductRepository()
        {
            _db = new DataBase();
        }

        public List<Product> GetProducts()
        {
            return _db.Products;
        }
        public Product GetById(int id)
        {
            return  _db.Products.FirstOrDefault(p => p.Id == id);
        }
        public void Create(Product entity)
        {
            Product product = new Product()
            {
                Id = _db.Products.Count + 1,
            };
            
            entity.Id = product.Id;
            _db.Products.Add(entity);

        }        
    }
}

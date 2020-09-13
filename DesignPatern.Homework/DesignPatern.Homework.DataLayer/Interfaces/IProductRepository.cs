using DesignPatern.Homework.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Homework.DataLayer.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void Create(Product entity);
        Product GetById(int id);

    }
}

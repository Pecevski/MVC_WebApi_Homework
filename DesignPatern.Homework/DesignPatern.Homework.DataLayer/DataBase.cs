using DesignPatern.Homework.DataLayer.DomainModels;
using DesignPatern.Homework.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Homework.DataLayer
{
    public class DataBase
    {
        public List<Product> Products { get; set; } = new List<Product>()
        {
           new Product
           {
              Id = 1,
              Name = "LG-TV",
              Price = 500.00,
              Description = "Smart TV",
              Category = ProductCategory.Electronics
           },
           new Product
           {
              Id = 2,
              Name = "MacBook",
              Price = 2000.00,
              Description = "Laptop",
              Category = ProductCategory.Electronics
           },
           new Product
           {
              Id = 3,
              Name = "Toyota CHR",
              Price = 33000.00,
              Description = "Electric Car",
              Category = ProductCategory.Cars
           },
           new Product
           {
              Id = 4,
              Name = "Porsche Carrera",
              Price = 100000.00,
              Description = "Car",
              Category = ProductCategory.Cars
           },
           new Product
           {
              Id = 5,
              Name = "C# in Depth",
              Price = 10.00,
              Description = "Programmers Book",
              Category = ProductCategory.Books
           },
           new Product
           {
              Id = 6,
              Name = "Broker",
              Price = 5.00,
              Description = "Belletristic",
              Category = ProductCategory.Books
           }
        };

    }
}

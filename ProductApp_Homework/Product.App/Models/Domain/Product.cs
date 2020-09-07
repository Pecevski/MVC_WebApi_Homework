using Products.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.App.Models.Domain
{
    public class Product
    {

        //Application features:
        //The product should have an unique identifier, name, price, description and category(electronics, books, etc.)

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory  Category { get; set; }
    }
}

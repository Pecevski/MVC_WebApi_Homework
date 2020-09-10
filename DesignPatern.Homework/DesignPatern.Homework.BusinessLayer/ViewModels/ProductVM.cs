using DesignPatern.Homework.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Homework.BusinessLayer.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
    }
}

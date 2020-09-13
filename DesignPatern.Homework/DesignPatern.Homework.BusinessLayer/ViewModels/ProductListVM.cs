using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Homework.BusinessLayer.ViewModels
{
    public class ProductListVM
    {
        public List<ProductVM> Products { get; set; }
        public int NumberOfProducts { get; set; }
    }
}

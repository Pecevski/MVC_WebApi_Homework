using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.App.Models.ViewModels
{
    public class ProductListVM
    {
        public List<ProductVM> Products { get; set; }
        public int NumberOfProducts { get; set; }
    }
}

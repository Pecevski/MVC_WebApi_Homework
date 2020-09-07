using Products.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.App.Models.ViewModels
{
    public class CreateProductListVM
    {
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        [Display(Name = "Product Price")]
        public double Price { get; set; }
        [Display(Name = "Category of the Product")]
        public ProductCategory Category { get; set; }

    }
}

using DesignPatern.Homework.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatern.Homework.BusinessLayer.ViewModels
{
    public class CreateProductListVM
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Product Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category of the Product")]
        public ProductCategory Category { get; set; }

    }
}

using DesignPatern.Homework.BusinessLayer.ViewModels;
using DesignPatern.Homework.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.Homework.BusinessLayer.Interfaces
{
    public interface IProductServices
    {
 
        ProductListVM Products();
        ProductVM CreateProduct(CreateProductListVM createProduct);
        ProductVM GetProductDetails(int id);
    }
}

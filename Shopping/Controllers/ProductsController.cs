using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(int id = -1)
        {
            List<ProductModel> Product = new List<ProductModel>();
            Product.Add(new ProductModel(1,"test",10.1f));
            Product.Add(new ProductModel(2, "test2", 15.1f));
            Product.Add(new ProductModel(3, "test3", 17.1f));

            ViewData["Product"] = Product;
            ViewData["id"] = id;

            return View();
        }

        public IActionResult Details(int id = 1)
        {
            List<ProductModel> Product = new List<ProductModel>();
            Product.Add(new ProductModel(1, "test", 10.1f));
            Product.Add(new ProductModel(2, "test2", 15.1f));
            Product.Add(new ProductModel(3, "test3", 17.1f));

            ViewData["Product"] = Product;
            ViewData["id"] = id;


            return View();
        }
    }
}

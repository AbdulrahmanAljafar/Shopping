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
        public IActionResult Index(int id = -1,string Color = "white")
        {
            List<ProductModel> Product = new List<ProductModel>();
            Product.Add(new ProductModel(1, "Espresso Machine", 10.1f, "https://www.ekuep.com/img/cms/Elementor%202/4740-thickbox_default%20(1).jpg"));
            Product.Add(new ProductModel(2, "Black Coffee", 15.1f, "https://images.indianexpress.com/2015/10/black-coffee_759_petr-kratochvil_wikimedia-commons.jpg"));
            Product.Add(new ProductModel(3, "Espresso", 17.1f, "https://www.illy.com/content/dam/channels/website/consumer/global/recipies/Doppio-tazza-media_mobile.jpg"));

            ViewData["Product"] = Product;
            ViewData["color"] = Color;
            ViewData["id"] = id;
            
            return View();
        }

        public IActionResult Details(int? id)
        {

            List<ProductModel> Product = new List<ProductModel>();
            Product.Add(new ProductModel(1, "Espresso Machine", 10.1f, "https://www.ekuep.com/img/cms/Elementor%202/4740-thickbox_default%20(1).jpg"));
            Product.Add(new ProductModel(2, "Black Coffee", 15.1f, "https://images.indianexpress.com/2015/10/black-coffee_759_petr-kratochvil_wikimedia-commons.jpg"));
            Product.Add(new ProductModel(3, "Espresso", 17.1f, "https://www.illy.com/content/dam/channels/website/consumer/global/recipies/Doppio-tazza-media_mobile.jpg"));

            ProductModel Product1 = Product.Find(b => b.id == id);

            if (Product1 == null)
            {
                return Content("Not found");
            }
            else
            {
                ViewData["Product"] = Product;
                ViewData["id"] = id;


                return View();
            }
        }
    }
}

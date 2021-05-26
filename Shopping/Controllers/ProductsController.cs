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

      private  List<ProductModel> Product = new List<ProductModel>() {
       new ProductModel(1, "Espresso Machine", 300.1f, "https://www.ekuep.com/img/cms/Elementor%202/4740-thickbox_default%20(1).jpg"),
       new ProductModel(2, "Black Coffee", 15.1f, "https://images.indianexpress.com/2015/10/black-coffee_759_petr-kratochvil_wikimedia-commons.jpg"),
       new ProductModel (3, "Espresso", 17.1f, "https://www.illy.com/content/dam/channels/website/consumer/global/recipies/Doppio-tazza-media_mobile.jpg"),
       new ProductModel (4, "PHILIPS", 370.1f, "https://images-na.ssl-images-amazon.com/images/I/61tSQahR8vL._AC_SL1277_.jpg"),

       

       };
       
        public IActionResult Index(int id = -1,string Color = "white")
        {
            
            ViewData["Product"] = Product;
            ViewData["color"] = Color;
            ViewData["id"] = id;
            
            return View();
        }

        public IActionResult Details(int? id)
        {

            

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

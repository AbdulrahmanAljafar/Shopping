using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public string image { get; set; }

        public ProductModel(int id,string Name,float Price,string image)
        {
            this.id = id;
            this.Name = Name;
            this.Price = Price;
            this.image = image;

        }


    }
}

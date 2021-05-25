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

        public ProductModel(int id,string Name,float Price)
        {
            this.id = id;
            this.Name = Name;
            this.Price = Price;

        }


    }
}

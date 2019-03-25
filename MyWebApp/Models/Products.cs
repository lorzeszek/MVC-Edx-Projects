using System;
using System.Collections.Generic;

namespace MyWebApp.Models {
    public class Product {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Password { get; set; }

        public Product(){}

        public Product(int id, string name, double price, int password) {
            this.ID = id; this.Name = name; this.Price = price; this.Password = password;
        }

    }

    public class Discount {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Rate { get; set; }
    }

    public class ProductListVM {
        public Discount Discount { get; set; }
        public IList<Product> Products { get; set; }
    }
}
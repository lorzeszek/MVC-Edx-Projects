using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers {
    public class ProductController : Controller {
            public IActionResult Index() {
            var vm = new ProductListVM();
            vm.Discount = new Discount { Start = DateTime.Today, End = DateTime.Today.AddDays(30), Rate = 0.75 };
            vm.Products = new List<Product>();
            vm.Products.Add(new Product { ID = 101, Name = "Book", Price = 20 });
            vm.Products.Add(new Product { ID = 102, Name = "Bike", Price = 30 });
            vm.Products.Add(new Product { ID = 103, Name = "Fireworks", Price = 40 });
            return View("ProductList", vm);
        }
        public IActionResult ShowAll() {
            ViewData["Heading"] = "All Products";
            var products = new List<Product>();
            products.Add(new Product { ID = 101, Name = "Apple", Price = 1.1 });
            products.Add(new Product { ID = 202, Name = "Bike", Price = 2.2 });
            products.Add(new Product { ID = 303, Name = "Calculator", Price = 3.3 });
            return View(products);
            }

            // Edit single product
        public IActionResult Edit() {
            var product = new Product(901, "Rocket", 99.99, 123456789);
            return View(product);
        }

        // Show a product list
        public IActionResult Show() {
            var products = new List<Product>();
            products.Add(new Product(101, "Apple", 19.99, 123456789));
            products.Add(new Product(201, "Bike", 29.99, 123456789));
            products.Add(new Product(301, "Couch", 39.99, 123456789));
            return View(products);
        }

    }
}
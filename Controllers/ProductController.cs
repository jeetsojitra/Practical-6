using practical_6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace practical_6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();
            Product P1 = products.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Laptop", Description = "Dell Laptop", Price = 55000, Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Mobile", Description = "Samsung Mobile", Price = 100000, Category = "Electronics" },
                new Product { ProductId = 3, ProductName = "Headphones", Description = "Wireless Headphones", Price = 20000, Category = "Electronics" },
            };
        }
    }
}
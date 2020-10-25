using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProductShop.Models;

namespace MyProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            //Calls the method that gets a partciular product by ID
            var product = Database.GetProduct(slugLink);  
            return View(product);
        }

        public IActionResult List()
        {
            //Calls the method that gets all the products
            var Allproducts = Database.GetAllProducts();
            return View(Allproducts);
        }
    }
}

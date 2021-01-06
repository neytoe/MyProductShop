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
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}

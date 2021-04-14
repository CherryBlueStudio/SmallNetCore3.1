using Microsoft.AspNetCore.Mvc;
using StevesProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevesProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = Database.GetProduct(slugLink);

            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = Database.GetProducts();

            return View(products);
        }
    }
}

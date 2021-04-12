using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevesProductShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Slug is used to create a better looking URL
        // by replacing spaces with dashes
        public string Slug => Name.Replace(' ', '-');
    }
}

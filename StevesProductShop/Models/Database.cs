using System.Collections.Generic;

namespace StevesProductShop.Models
{
    public class Database
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },

                new Product
                {
                    ProductID = 2,
                    Name = "Shiny Box",
                    Price = (decimal) 699.00
                },

                new Product
                {
                    ProductID = 3,
                    Name = "Rusted Knife",
                    Price = (decimal) 99.00
                },

                new Product
                {
                    ProductID = 4,
                    Name = "Elongated Ball",
                    Price = (decimal) 299.00
                },

                new Product
                {
                    ProductID = 5,
                    Name = "Shaving Cream Dispenser",
                    Price = (decimal) 19.00
                }
             };

            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = Database.GetProducts();

            foreach(Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProductShop.Models
{
    //This models simulates a database for this application
    public class Database
    {
        public static List<Product> GetProduct()
        {
            List<Product> product = new List<Product>
            {
                new Product
                {
                    ProductID =1,
                    Name = "Product1",
                    Price= (decimal)499.00
                },
                new Product
                {
                    ProductID =2,
                    Name = "Best product Ever",
                    Price= (decimal) 1199.00
                },
                 new Product
                {
                    ProductID =3,
                    Name = " product",
                    Price= (decimal) 99.00
                },
                 new Product
                {
                    ProductID =4,
                    Name = "Biscuit",
                    Price= (decimal) 99.00
                },
                 new Product
                {
                    ProductID =5,
                    Name = "Banana",
                    Price= (decimal) 99.00
                },
                 new Product
                {
                    ProductID =6,
                    Name = " product",
                    Price= (decimal) 99.00
                },
                 new Product
                {
                    ProductID =7,
                    Name = " apple ",
                    Price= (decimal) 199.00
                },
                  new Product
                {
                    ProductID =8,
                    Name = "Cashew",
                    Price= (decimal) 199.00
                },
                   new Product
                {
                    ProductID =9,
                    Name = "apple",
                    Price= (decimal) 29.00
                }
            };
            return product;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = Database.GetProduct();
            foreach (var item in products)
            {
                if (item.Slug == slug)
                {
                    return item;
                } 
            }
            return null;
        }
    }

}

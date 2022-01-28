using E_SourcingMicroServices.Entities;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;

namespace E_SourcingMicroServices.Data.Interfaces
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct= productCollection.Find(p=>true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-1.png",
                    Price = 950.00M,
                    Category = "smart Phone"

                },
                new Product()
                {
                    Name = "Samsung 10",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-2.png",
                    Price = 840.00M,
                    Category = "smart Phone"

                },
                new Product()
                {
                    Name = "Huawei Plus",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-3.png",
                    Price = 650.00M,
                    Category = "White Appliances"

                },
                new Product()
                {
                    Name = "Xiaomi Mi 9",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-4.png",
                    Price = 470.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Htc U11 Plus+",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-5.png",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "LG G7 thinQ",
                    Summary = "This phone is the company's biggest change to it flapping smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsum ",
                    ImageFile= "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
}
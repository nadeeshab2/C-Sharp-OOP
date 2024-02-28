﻿using System;

namespace InventorySystem
{
    class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }


        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product("Laptop", 999.99m);
            Product product2 = new Product("Smartphone", 599.99m);

            DisplayProduct(product1);
            DisplayProduct(product2);


            Console.ReadKey();
        }

        static void DisplayProduct(Product product)
        {
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: {product.Price:C}");
            Console.WriteLine();
        }
    }
}

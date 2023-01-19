using System;
using System.Collections.Generic;
using System.Text;

namespace ElasticCollection.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }

        public Product(int id, string name, int quantity, double price, string category, int ordercount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Category = category;
            OrderCount = ordercount;
        }
    }
}
